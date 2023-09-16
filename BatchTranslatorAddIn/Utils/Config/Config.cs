using BatchTranslatorAddIn.Properties;
using BatchTranslatorAddIn.Utils.Common;
using Newtonsoft.Json;

namespace BatchTranslatorAddIn.Utils.Config
{
    /**
     * <summary>封装配置项</summary>
     */
    internal class Config
    {
        public Language From { get; set; }

        public Language To { get; set; }

        public Direction GenerateDirection { get; set; }

        public TransEngine TransEngine { get; set; }

        public BaiduProperty BaiduProperty { get; set; }

        public CaiyunProperty CaiyunProperty { get; set; }

        private Config() {
            // Set Default Value
            From = Language.JP;
            To = Language.CN;
            GenerateDirection = Direction.Right;
            TransEngine = TransEngine.Baidu;
            BaiduProperty = new BaiduProperty() { AppID = "", Secret = "", QPS = 10 };
            CaiyunProperty = new CaiyunProperty() { Token = "", QPS = 10};
        }

        private static Config instance;
        public static Config Instance
        {
            get
            {
                if (instance == null)
                {
                    var rawData = Settings.Default.Config;
                    instance = JsonConvert.DeserializeObject<Config>(rawData);
                }
                return instance;
            }
        }

        public void Save()
        {
            Settings.Default.Config = JsonConvert.SerializeObject(instance, Formatting.Indented);
        }
    }
}
