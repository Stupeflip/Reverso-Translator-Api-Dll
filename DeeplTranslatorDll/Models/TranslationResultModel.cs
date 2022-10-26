namespace ReversoTranslatorDll.Models
{
    public enum Language
    {
        GE,
        EN,
        AS,
        CN,
        KR,
        ES,
        FR,
        HE, //Hebrew (language)
        IT,
        JP,
        NE,
        PL,
        PT,
        RO,
        RU,
        SE,
        TR,
        UA
    }

    public class TranslationResultModel
    {
        public string Result { get; set; }

        public LanguageModel TranslationLanguages { get; set; }

        public IEnumerable<string> SourceExamples { get; set; }

        public IEnumerable<string> TargetExamples { get; set; }

        public TranslationResultModel(string result, LanguageModel translationLanguages, IEnumerable<string> sourceExamples, IEnumerable<string> targetExamples)
        {
            Result = result;
            TranslationLanguages = translationLanguages;
            SourceExamples = sourceExamples;
            TargetExamples = targetExamples;
        }
    }
}
