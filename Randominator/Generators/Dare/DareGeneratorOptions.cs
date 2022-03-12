namespace TehGM.Randominator.Generators.Dare
{
    public class DareGeneratorOptions
    {
        public double AdverbChance { get; set; } = 0.48;
        public IDictionary<string, string> ArticleOverrides { get; set; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "hour", "an" },
            { "one", "a" },
            { "dirt", "some" },
            { "metal", "the" },
            { "fishing", "the" },
            { "safety", "the" },
            { "money", "some" },
            { "special", "the" },
            { "tomorrow", "the" },
            { "minimum", "the" },
            { "east", "the" },
            { "space", "the" },
            { "birth", "the" },
            { "news", "the" },
            { "water", "some" },
            { "yesterday", "the" },
            { "transportation", "the" },
            { "rich", "the" },
            { "people", "some" },
            { "sky", "the" },
            { "cold", "the" },
            { "internet", "the" },
            { "sick", "the" },
            { "traffic", "the" }
        };

        public IDictionary<string, string> VerbTransformations { get; set; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "listen", "listen to" },
            { "reason", "reason with" }
        };
    }
}
