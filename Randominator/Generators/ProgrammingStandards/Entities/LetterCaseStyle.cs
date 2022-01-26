namespace TehGM.Randominator.Generators.ProgrammingStandards
{
    public enum LetterCaseStyle
    {
        /// <summary>Letter case: MemberName.</summary>
        [DisplayName("PascalCase", "UpperCamelCase", "StudlyCase", "TheOnlyGoodCase", "EpicCase", "EliteCase")]
        PascalCase = 0,
        /// <summary>Letter case: memberName.</summary>
        [DisplayName("camelCase", "dromedaryCase", "lowerCamelCase", "uglyCase")]
        CamelCase = 1,
        /// <summary>Letter case: membername.</summary>
        [DisplayName("flatcase", "lowerflatcase", "lowercase", "lazycase", "lazybumcase")]
        FlatCase = 2,
        /// <summary>Letter case: MEMBERNAME.</summary>
        [DisplayName("UPPERFLATCASE", "UPPERCASE", "SCREAMINGCASE", "WININTERNETFIGHTSCASE")]
        UpperFlatCase = 3,
        /// <summary>Letter case: member_name.</summary>
        [DisplayName("snake_case", "pothole_case", "ugly_separator_case")]
        SnakeCase = 4,
        /// <summary>Letter case: MEMBER_NAME.</summary>
        [DisplayName("SCREAMING_SNAKE_CASE", "UPPER_SNAKE_CASE", "MACRO_CASE", "CONSTANT_CASE", "SCREAMING_UGLY_SEPARATOR_CASE")]
        ScreamingSnakeCase = 5,
        /// <summary>Letter case: member_Name.</summary>
        [DisplayName("camel_Snake_Case", "ugly_Snake_Case")]
        CamelSnakeCase = 6,
        /// <summary>Letter case: Member_Name.</summary>
        [DisplayName("Pascal_Snake_Case", "Wannabe_Pascal_Case_But_Ugly_Separators_Case")]
        PascalSnakeCase = 7,
        /// <summary>Letter case: member-name.</summary>
        [DisplayName("kebab-case", "dash-case", "lisp-case", "spinal-case", "i-want-a-kebab-case", "i-am-hungry-case")]
        KebabCase = 8,
        /// <summary>Letter case: MEMBER-NAME.</summary>
        [DisplayName("TRAIN-CASE", "COBOL-CASE", "SCREAMING-KEBAB-CASE", "I-REALLY-WANT-THAT-KEBAB-CASE", "I-AM-STARVING-CASE")]
        TrainCase = 9,
        /// <summary>Letter case: Member-Name.</summary>
        [DisplayName("Pascal-Train-Case", "HTTP-Header-Case", "Almost-Cool-Kebab-Case")]
        PascalKebabCase = 10,
        /// <summary>Letter case: MeMbErNaMe.</summary>
        [DisplayName("PoKeMoNcAsE", "AlTeRnAtInGcAsE", "sPoNgEbObCaSe", "EmOcAsE", "ScEnEcAsE", "tEeNaGeAnGsTcAsE")]
        PokemonCase = 11,
        /// <summary>Letter case: MemBErnaMe.</summary>
        [DisplayName("raNDoMcaSE", "REtArdcASe", "BrAiNDAmagecASE")]
        RandomCase = 12
    }
}
