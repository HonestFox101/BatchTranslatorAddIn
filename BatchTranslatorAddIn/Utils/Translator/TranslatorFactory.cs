using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System;
using Newtonsoft.Json;
using BatchTranslatorAddIn.Utils.Common;
using System.Net.Http;

namespace BatchTranslatorAddIn.Utils.Translator
{
    public abstract class TranslatorFactory
    {
        static readonly Config.Config config = Config.Config.Instance;

        public static ITranslator CreateBaiduTranslator()
        {
            var baiduProperty = config.BaiduProperty;
            var appid = baiduProperty.AppID;
            var secret = baiduProperty.Secret;
            var qps = baiduProperty.QPS;

            var from = config.From;
            var to = config.To;
            return new BaiduTranslator(appid, secret, from, to, qps);
        }
        public static ITranslator CreateCaiyunTranslator()
        {
            var caiyunProperty = config.CaiyunProperty;
            var token = caiyunProperty.Token;
            var qps = caiyunProperty.QPS;

            var from = config.From;
            var to = config.To;
            return new CaiyunTranslator(token, from, to, qps);
        }

        class BaiduTranslator : ITranslator
        {
            readonly string url = "https://fanyi-api.baidu.com/api/trans/vip/translate";
            readonly string _appid;
            readonly string _secret;

            readonly Dictionary<Language, string> langConvertMap = new Dictionary<Language, string>()
            {
                { Language.CN, "zh" },
                { Language.EN, "en" },
                { Language.JP, "jp" }
            };

            struct ResponseBody
            {
                public struct TranResult
                {
                    public string src;
                    public string dst;

                    public TranResult(string src, string dst)
                    {
                        this.src = src;
                        this.dst = dst;
                    }
                }
                public string from;
                public string to;
                public List<TranResult> trans_result;
                public int? error_code;
                public string error_msg;

                public ResponseBody(string from, string to, List<TranResult> trans_result, int? error_code, string error_msg)
                {
                    this.from = from;
                    this.to = to;
                    this.trans_result = trans_result;
                    this.error_code = error_code;
                    this.error_msg = error_msg;
                }
            }


            public BaiduTranslator(string appid, string secret, Language from, Language to, int qps)
            {
                _appid = appid;
                _secret = secret;
                From = from;
                To = to;
                QPS = qps;
            }

            public Language From { get; set; }
            public Language To { get; set; }
            public int QPS { get; set; }

            public string Translate(string content)
            {
                if (!TryTranslate(content, out string result))
                    return "";
                return result;
            }

            public bool TryTranslate(string content, out string result)
            {
                string q = content;
                string salt = DateTime.UtcNow.Millisecond.ToString();
                string sign = MD5EncryptString(_appid + q + salt + _secret);
                string requestUrl = url + "?";
                requestUrl += "q=" + Uri.EscapeDataString(q);
                requestUrl += "&from=" + langConvertMap[From];
                requestUrl += "&to=" + langConvertMap[To];
                requestUrl += "&appid=" + _appid;
                requestUrl += "&salt=" + salt;
                requestUrl += "&sign=" + sign;

                var client = new HttpClient { Timeout = TimeSpan.FromSeconds(6) };
                var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
                var requestTask = client.SendAsync(request);
                requestTask.Wait();
                var resp = requestTask.Result;
                if (!resp.IsSuccessStatusCode)
                {
                    result = $"{{\"code\":{resp.StatusCode}, \"msg\":\"HTTP请求错误\"}}";
                    return false;
                }
                var readStringTask = resp.Content.ReadAsStringAsync();
                readStringTask.Wait();

                var transResult = JsonConvert.DeserializeObject<ResponseBody>(readStringTask.Result);
                if (transResult.error_code != null)
                {
                    result = $"{{\"code\":{transResult.error_code}, \"msg\":{transResult.error_msg}}}";
                    return false;
                }
                result = "";
                foreach (var line in transResult.trans_result)
                    result += line.dst + "\n";
                result = result.Substring(0, result.Length - 1);

                // 冷却
                var qps = QPS;
                Thread.Sleep(1000 / qps);
                return true;
            }
        }

        class CaiyunTranslator : ITranslator
        {
            readonly string url = "http://api.interpreter.caiyunai.com/v1/translator";
            readonly string token;
            readonly Dictionary<(Language from, Language to), string> langConvertMap = new Dictionary<(Language from, Language to), string>()
            {
                {(Language.JP, Language.CN), "ja2zh" },
                {(Language.EN, Language.CN), "en2zh" },
                {(Language.CN, Language.JP), "zh2ja"},
                {(Language.CN, Language.EN), "zh2en" }
            };
            struct ResponseResult
            {
                public int isdict;
                public double confidence;
                public string target;
                public int rc;

                public ResponseResult(int isdict, double confidence, string target, int rc)
                {
                    this.isdict = isdict;
                    this.confidence = confidence;
                    this.target = target;
                    this.rc = rc;
                }
            }
            public CaiyunTranslator(string token, Language from, Language to, int qps)
            {
                this.token = token;
                From = from;
                To = to;
                QPS = qps;
            }
            public Language From { get; set; }
            public Language To { get; set; }
            public int QPS { get; set; }

            public string Translate(string content)
            {
                if (!TryTranslate(content, out string result))
                    return "";
                return result;
            }

            public bool TryTranslate(string content, out string result)
            {
                var client = new HttpClient() { Timeout = TimeSpan.FromSeconds(6) };
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                object payload = new
                {
                    source = content,
                    trans_type = langConvertMap[(From, To)],
                    request_id = "demo",
                    detect = true
                };
                var requestBody = JsonConvert.SerializeObject(payload);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Content.Headers.Add("x-authorization", "token " + token);

                var requestTask = client.SendAsync(request);
                requestTask.Wait();
                var resp = requestTask.Result;
                if (!resp.IsSuccessStatusCode)
                {
                    result = $"Http request error: {resp.StatusCode}";
                    return false;
                }
                var readResponseTask = resp.Content.ReadAsStringAsync();
                readResponseTask.Wait();
                var transResultsString = readResponseTask.Result;

                var transResults = JsonConvert.DeserializeObject<ResponseResult>(transResultsString);
                result = transResults.target;

                // 冷却
                var qps = QPS;
                Thread.Sleep(1000 / qps);
                return true;
            }
        }

        // 计算MD5值
        static string MD5EncryptString(string input)
        {
            MD5 HashMD5 = MD5.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = HashMD5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }

    }
}
