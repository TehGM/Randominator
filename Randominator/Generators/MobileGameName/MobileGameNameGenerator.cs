namespace TehGM.Randominator.Generators.MobileGameName.Services
{
    public class MobileGameNameGenerator : IMobileGameNameGenerator
    {
        private readonly IOptionsMonitor<MobileGameNameOptions> _options;
        private readonly Random _random;
        private readonly ILogger _log;

        public MobileGameNameGenerator(IOptionsMonitor<MobileGameNameOptions> options, ILogger<MobileGameNameGenerator> log)
        {
            this._options = options;
            this._random = new Random();
            this._log = log;
        }

        public string Generate()
        {
            MobileGameNameOptions options = this._options.CurrentValue;
            this._log.LogDebug("Generating random game name. Total wrapper words in sets: {WrapperWordCount}", options.SharedWordSet.Count() + options.LeadingWordSet.Count() + options.TrailingWordSet.Count());

            // grab leading segment
            string leadingSegment = this.GetRandomValue(options.LeadingWordSet.Union(options.SharedWordSet));
            leadingSegment = this.CapitalizeWrapperSegment(leadingSegment);
            this._log.LogTrace("Leading segment generated: {SegmentValue}", leadingSegment);

            // grab middle segment
            string middleSegment = this.GetRandomValue(options.MiddleWordSet).ToLowerInvariant();
            this._log.LogTrace("Middle segment generated: {SegmentValue}", middleSegment);

            // grab leading segment
            string trailingSegment = this.GetRandomValue(options.TrailingWordSet.Union(options.SharedWordSet));
            trailingSegment = this.CapitalizeWrapperSegment(trailingSegment);
            this._log.LogTrace("Trailing segment generated: {SegmentValue}", trailingSegment);

            // combine result
            return string.Join(' ', leadingSegment, middleSegment, trailingSegment);
        }

        private string CapitalizeWrapperSegment(string value)
        {
            string[] segmentParts = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < segmentParts.Length; i++)
            {
                char[] wordChars = segmentParts[i].ToLowerInvariant().ToCharArray();
                wordChars[0] = Char.ToUpperInvariant(wordChars[0]);
                segmentParts[i] = new string(wordChars);
            }
            return string.Join(' ', segmentParts);
        }

        private T GetRandomValue<T>(IEnumerable<T> collection)
        {
            if (collection?.Any() != true)
                return default;

            int index = this._random.Next(0, collection.Count());
            return collection.ElementAtOrDefault(index);
        }
    }
}
