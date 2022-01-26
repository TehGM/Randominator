namespace TehGM.Randominator.Generators.ProgrammingStandards
{
    public class NamingStyle
    {
        public LetterCaseStyle LetterCaseStyle { get; }
        public string LetterCaseStyleName { get; }
        public string NormalPrefix { get; init; }
        public string NormalSuffix { get; init; }
        public HungarianPartStyle HungarianPrefix { get; init; }
        public HungarianPartStyle HungarianSuffix { get; init; }

        public NamingStyle(LetterCaseStyle caseStyle, string caseName)
        {
            this.LetterCaseStyle = caseStyle;
            this.LetterCaseStyleName = caseName;
        }

        public bool HasNormalPrefixOrSuffix
            => !string.IsNullOrWhiteSpace(this.NormalPrefix) || !string.IsNullOrWhiteSpace(this.NormalSuffix);

        public bool HasHungarianParts
            => this.HungarianPrefix != HungarianPartStyle.None || this.HungarianSuffix != HungarianPartStyle.None;
    }
}
