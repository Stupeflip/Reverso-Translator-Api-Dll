namespace ReversoTranslatorDll.Models
{
    public struct LanguageModel
    {
        public Tuple<Language, string> SelectedLanguage { get; set; }

        public Tuple<Language, string> TargetLanguage { get; set; }

        public LanguageModel(Language selectedLang, Language targetLang)
        {
            #region Lang Formatting
            string selectedLangStr = selectedLang switch
            {
                Language.GE => "ger",
                Language.EN => "eng",
                Language.AS => "ara",
                Language.CN => "chi",
                Language.KR => "kor",
                Language.ES => "spa",
                Language.FR => "fra",
                Language.HE => "heb",
                Language.IT => "ita",
                Language.JP => "jap",
                Language.NE => "dut",
                Language.PL => "pol",
                Language.PT => "por",
                Language.RO => "rum",
                Language.RU => "rus",
                Language.SE => "swe",
                Language.TR => "tur",
                Language.UA => "ukr",

                _ => "eng"
            };

            string targetLangStr = targetLang switch
            {
                Language.GE => "ger",
                Language.EN => "eng",
                Language.AS => "ara",
                Language.CN => "chi",
                Language.KR => "kor",
                Language.ES => "spa",
                Language.FR => "fra",
                Language.HE => "heb",
                Language.IT => "ita",
                Language.JP => "jap",
                Language.NE => "dut",
                Language.PL => "pol",
                Language.PT => "por",
                Language.RO => "rum",
                Language.RU => "rus",
                Language.SE => "swe",
                Language.TR => "tur",
                Language.UA => "ukr",

                _ => "eng"
            };
            #endregion

            SelectedLanguage = new(selectedLang, selectedLangStr);
            TargetLanguage = new(targetLang, targetLangStr);
        }
    }
}
