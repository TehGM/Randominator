namespace TehGM.Randominator.Generators.MobileGameName.Services
{
    public class MobileGameNameGenerator : IMobileGameNameGenerator
    {
        private readonly IOptionsMonitor<MobileGameNameOptions> _options;
        private readonly IRandomizer _random;
        private readonly ILogger _log;

        public MobileGameNameGenerator(IOptionsMonitor<MobileGameNameOptions> options, ILogger<MobileGameNameGenerator> log, IRandomizer randomizer)
        {
            this._options = options;
            this._random = randomizer;
            this._log = log;
        }

        public string Generate()
        {
            MobileGameNameOptions options = this._options.CurrentValue;
            this._log.LogDebug("Generating random game name. Total wrapper words in sets: {WrapperWordCount}", options.SharedWordSet.Count() + options.LeadingWordSet.Count() + options.TrailingWordSet.Count());

            ICollection<string> segments = new List<string>(5);
            if (this._random.RollChance(options.PrefixChance))
                this.BuildSegment("Leading Prefix", options.PrefixWordSet, true, ref segments);
            this.BuildSegment("Leading", options.LeadingWordSet.Union(options.SharedWordSet), true, ref segments);
            this.BuildSegment("Middle", options.MiddleWordSet, false, ref segments);
            if (this._random.RollChance(options.PrefixChance))
                this.BuildSegment("Trailing Prefix", options.PrefixWordSet, true, ref segments);
            this.BuildSegment("Trailing", options.TrailingWordSet.Union(options.SharedWordSet), true, ref segments);

            return string.Join(' ', segments);
        }

        void BuildSegment(string name, IEnumerable<string> values, bool capitalize, ref ICollection<string> outputs)
        {
            string segment = this._random.GetRandomValue(values);
            if (capitalize)
                segment = this.CapitalizeSegment(segment);

            if (!string.IsNullOrWhiteSpace(segment))
            {
                outputs.Add(segment);
                this._log.LogTrace("{SegmentName} segment generated: {SegmentValue}", name, segment);
            }
            else
                this._log.LogTrace("{SegmentName} segment empty", name);
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
