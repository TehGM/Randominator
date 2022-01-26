namespace TehGM.Randominator.Generators.ProgrammingStandards
{
    public class HungarianPart
    {
        public static HungarianPart Integer { get; } = new HungarianPart("int", "integer");
        public static HungarianPart String { get; } = new HungarianPart("str", "string");
        public static HungarianPart Class { get; } = new HungarianPart("cls", "class");
        public static HungarianPart Struct { get; } = new HungarianPart("s", "struct");
        public static HungarianPart Interface { get; } = new HungarianPart("i", "interface");

        public string ShortVersion { get; }
        public string LongVersion { get; }

        public HungarianPart(string shortVersion, string longVersion)
        {
            if (string.IsNullOrWhiteSpace(shortVersion))
                throw new ArgumentNullException(nameof(shortVersion));
            if (string.IsNullOrWhiteSpace(longVersion))
                throw new ArgumentNullException(nameof(longVersion));

            this.ShortVersion = shortVersion;
            this.LongVersion = longVersion;
        }

        public override string ToString()
            => this.ToString(HungarianPartStyle.Long);

        public string ToString(HungarianPartStyle style)
        {
            if (style == HungarianPartStyle.Short)
                return this.ShortVersion;
            else if (style == HungarianPartStyle.Long)
                return this.LongVersion;
            return null;
        }
    }
}
