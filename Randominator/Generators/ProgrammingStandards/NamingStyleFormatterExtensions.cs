namespace TehGM.Randominator.Generators.ProgrammingStandards
{
    public static class NamingStyleFormatterExtensions
    {
        public static string Apply(this INamingStyleFormatter formatter, NamingStyle style, IEnumerable<string> words, HungarianPart hungarianPart)
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

            // apply style to each word
            for (int i = 0; i < results.Count; i++)
                results[i] = formatter.ApplyToWord(style, results[i], i == 0);

            // merge words and return
            return formatter.MergeWords(style, results);

            void AddWordLeading(string word)
                => results.InsertRange(0, word.Split(' '));
            void AddWordTrailing(string word)
                => results.AddRange(word.Split(' '));
        }

        public static string ApplyToWord(this INamingStyleFormatter formatter, NamingStyle style, string word, bool isLeading = false)
            => formatter.ApplyToWord(style.LetterCaseStyle, word, isLeading);

        public static string MergeWords(this INamingStyleFormatter formatter, NamingStyle style, IEnumerable<string> words)
            => formatter.MergeWords(style.LetterCaseStyle, words);

        public static string MergeWords(this INamingStyleFormatter formatter, NamingStyle style, params string[] words)
            => MergeWords(formatter, style, words.AsEnumerable());

        public static string MergeWords(this INamingStyleFormatter formatter, LetterCaseStyle style, params string[] words)
            => formatter.MergeWords(style, words.AsEnumerable());
    }
}
