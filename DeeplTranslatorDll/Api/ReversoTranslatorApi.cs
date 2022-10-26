using System.Text;
using System.Text.RegularExpressions;

namespace ReversoTranslatorDll.Api
{
    public class ReversoTranslatorApi
    {
        private static readonly HttpClient _client = new();

        public async Task<TranslationResultModel?> HandleJobAsync(LanguageModel language, params string[] words)
        {
            string sentence = string.Join(" ", words);

            HttpRequestMessage reqMsg = new(HttpMethod.Post, "https://api.reverso.net/translate/v1/translation")
            {
                Content = new StringContent($"{{\"format\":\"text\",\"from\":\"{language.SelectedLanguage.Item2}\",\"to\":\"{language.TargetLanguage.Item2}\",\"input\":\"{sentence}\",\"options\":{{\"sentenceSplitter\":true,\"origin\":\"translation.web\",\"contextResults\":true,\"languageDetection\":true}}}}", Encoding.UTF8, "application/json")
            };

            HttpResponseMessage resp = await _client.SendAsync(reqMsg);

            if (!resp.IsSuccessStatusCode)
                return null;

            var json = JsonSerializer.Deserialize<JsonElement>(await resp.Content.ReadAsStringAsync());

            if (json.GetProperty("translation").EnumerateArray().Count() == 0)
                return null;

            string translationResult = json.GetProperty("translation")
                .EnumerateArray()
                .Single().ToString();

            var ctxResultArr = json
                .GetProperty("contextResults")
                .GetProperty("results").EnumerateArray().First();

            return new(translationResult, language,
                ctxResultArr.GetProperty("sourceExamples")
                .EnumerateArray()
                .Select(e => Regex.Replace(e.ToString(), "(<em>|</em>)", string.Empty)).ToList(),
                ctxResultArr.GetProperty("targetExamples")
                .EnumerateArray()
                .Select(e => Regex.Replace(e.ToString(), "(<em>|</em>)", string.Empty)).ToList());
        }
    }
}