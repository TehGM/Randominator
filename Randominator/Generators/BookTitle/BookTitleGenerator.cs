namespace TehGM.Randominator.Generators.BookTitle.Services
{
    public class BookTitleGenerator : IBookTitleGenerator
    {
        private readonly IOptionsMonitor<BookTitleOptions> _options;
        private readonly IRandomizer _random;
        private readonly ILogger _log;

        public BookTitleGenerator(IOptionsMonitor<BookTitleOptions> options, ILogger<BookTitleGenerator> log, IRandomizer randomizer)
        {
            this._options = options;
            this._random = randomizer;
            this._log = log;
        }

        public string Generate()
        {
            BookTitleOptions options = this._options.CurrentValue;
            ICollection<string> segments = new List<string>(3);
            //pick if it's A or An for the first word
            bool useAWordSet = _random.RollChance(0.5); // 50% chance to pick either list

            string article = useAWordSet ? "A" : "An";
            string word1 = useAWordSet
                ? this._random.GetRandomValue(options.AWordSet)
                : this._random.GetRandomValue(options.AnWordSet);

            //Second or third word
            string word2 = this._random.GetRandomValue(options.SecondThirdWordSet);
            string word3 = this._random.GetRandomValue(options.SecondThirdWordSet);

            //we probably don't want it to be the same one twice
            while (word2 == word3)
                word3 = this._random.GetRandomValue(options.SecondThirdWordSet);
            // combine it 
            segments.Add($"{article} {this.CapitalizeSegment(word1)} of {this.CapitalizeSegment(word2)} and {this.CapitalizeSegment(word3)}");
            return string.Join(' ', segments);
        }


       

        private string CapitalizeSegment(string value)
        {
            string[] segmentParts = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < segmentParts.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(segmentParts[i]))
                    continue;
                char[] wordChars = segmentParts[i].ToLowerInvariant().ToCharArray();
                wordChars[0] = char.ToUpperInvariant(wordChars[0]);
                segmentParts[i] = new string(wordChars);
            }
            return string.Join(' ', segmentParts);
        }
    }
}
