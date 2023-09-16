using BatchTranslatorAddIn.Utils.Common;

namespace BatchTranslatorAddIn.Utils.Translator
{
    public interface ITranslator
    {
        int QPS { get; set; }
        Language From { get; set; }
        Language To { get; set; }

        string Translate(string content);

        bool TryTranslate(string content, out string result);
    }
}
