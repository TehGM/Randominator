namespace TehGM.Randominator.Generators.Dare
{
    public class DareGeneratorOptions
    {
        public double AdverbChance { get; set; } = 0.39;
        public IDictionary<string, string> ArticleOverrides { get; set; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "hour", "an" },
            { "one", "a" },
            { "dirt", "some" },
            { "metal", "the" },
            { "fishing", "the" },
            { "safety", "the" },
            { "money", "some" },
            { "cash", "some" },
            { "special", "the" },
            { "tomorrow", "the" },
            { "minimum", "the" },
            { "east", "the" },
            { "west", "the" },
            { "north", "the" },
            { "south", "the" },
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
            { "traffic", "the" },
            { "fun", "some" },
            { "dust", "some" },
            { "history", "the" },
            { "length", "the" },
            { "hair", "" },
            { "blind", "the" },
            { "depression", "the" },
            { "public", "the" },
            { "economics", "the" },
            { "soil", "the" },
            { "salary", "" },
            { "rice", "some" },
            { "hurt", "some" },
            { "temporary", "the" },
            { "salt", "some" }
        };

        public IDictionary<string, string> VerbTransformations { get; set; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "listen", "listen to" },
            { "reason", "reason with" },
            { "sight", "sight at" },
            { "travel", "travel to" },
            { "wink", "wink at" }
        };
    }
}
