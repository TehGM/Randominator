namespace TehGM.Randominator.Generators.ProgrammingStandards
{
    public static class NamingStyleFormatterExtensions
    {
        public static string ApplyStyle(this INamingStyleFormatter formatter, NamingStyle style, IEnumerable<string> words, HungarianPart hungarianPart)
        {
            List<string> results = new List<string>(words);

            // apply suffixes - normal wrap hungarian ones
            if (hungarianPart != null)
            {
                if (style.HungarianPrefix != HungarianPartStyle.None)
                    AddWordLeading(hungarianPart.ToString(style.HungarianPrefix));
                if (style.HungarianSuffix != HungarianPartStyle.None)
                    AddWordTrailing(hungarianPart.ToString(style.HungarianSuffix));
            }
            if (!string.IsNullOrWhiteSpace(style.NormalPrefix))
                AddWordLeading(style.NormalPrefix);
            if (!string.IsNullOrWhiteSpace(style.NormalSuffix))
                AddWordTrailing(style.NormalSuffix);

            // apply style, merge words and return
            return ChangeLetterCaseAndMerge(formatter, style, results, true);

            void AddWordLeading(string word)
                => results.InsertRange(0, word.Split(' '));
            void AddWordTrailing(string word)
                => results.AddRange(word.Split(' '));
        }

        public static IEnumerable<string> ChangeLetterCase(this INamingStyleFormatter formatter, NamingStyle style, IEnumerable<string> words, bool isLeading = true)
        {
            List<string> results = new List<string>(words);

            // prefixes like _ will cause camelCase to become PascalCase
            // for this reason, we need to find index of actual leading word
            int leadingWordIndex = IsLeadingWord(results.First()) ? 0 : 1;

            // apply style to each word
            for (int i = 0; i < results.Count; i++)
                results[i] = formatter.ChangeLetterCase(style, results[i], isLeading && i <= leadingWordIndex);
            return results;

            bool IsLeadingWord(string word)
                => word.All(c => char.IsDigit(c) || char.IsLetter(c));
        }

        public static string ChangeLetterCaseAndMerge(this INamingStyleFormatter formatter, NamingStyle style, IEnumerable<string> words, bool isLeading = true)
            => formatter.MergeWords(style, ChangeLetterCase(formatter, style, words, isLeading));

        public static string ChangeLetterCase(this INamingStyleFormatter formatter, NamingStyle style, string word, bool isLeading = true)
            => formatter.ChangeLetterCase(style.LetterCaseStyle, word, isLeading);

        public static string MergeWords(this INamingStyleFormatter formatter, NamingStyle style, IEnumerable<string> words)
            => formatter.MergeWords(style.LetterCaseStyle, words);

        public static string MergeWords(this INamingStyleFormatter formatter, NamingStyle style, params string[] words)
            => MergeWords(formatter, style, words.AsEnumerable());

        public static string MergeWords(this INamingStyleFormatter formatter, LetterCaseStyle style, params string[] words)
            => formatter.MergeWords(style, words.AsEnumerable());
    }
}
