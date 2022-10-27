namespace ReversoTranslatorDll.Models
{

    /// <summary>
    /// Country flags : 
    /// GE : German
    /// EN : English
    /// AS : Arabic
    /// CN : Chinese
    /// KR : Korean
    /// ES : Spanish
    /// FR : French
    /// HE : Hebrew
    /// IT : Italian
    /// JP : Japan
    /// NE : Dutch
    /// PL : Polish
    /// PT : Portuguese
    /// RO : Romanian
    /// RU : Russian
    /// SE : Swedish
    /// TR : Turkish
    /// UA : Ukrainian
    /// </summary>
    public enum Language
    {
        GE,
        EN,
        AS,
        CN,
        KR,
        ES,
        FR,
        HE, //Hebrew (   language)
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
