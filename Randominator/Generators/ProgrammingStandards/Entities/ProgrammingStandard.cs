namespace TehGM.Randominator.Generators.ProgrammingStandards
{
    public class ProgrammingStandard
    {
        public string LanguageName { get; }

        public BracketsStyle TypeBracketsStyle { get; init; }
        public BracketsStyle MethodBracketsStyle { get; init; }
        public BracketsStyle LoopBracketsStyle { get; init; }
        public BracketsStyle FlowControlBracketsStyle { get; init; }

        public NamingStyle ClassNamingStyle { get; init; }
        public NamingStyle StructNamingStyle { get; init; }
        public NamingStyle InterfaceNamingStyle { get; init; }
        public NamingStyle MethodNamingStyle { get; init; }
        public NamingStyle MethodArgumentNamingStyle { get; init; }
        public NamingStyle PropertyNamingStyle { get; init; }
        public NamingStyle PublicFieldNamingStyle { get; init; }
        public NamingStyle PrivateFieldNamingStyle { get; init; }
        public NamingStyle LocalFieldNamingStyle { get; init; }
        public NamingStyle ConstantNamingStyle { get; init; }

        public AllowMode AllowLoops { get; init; }
        public AllowMode AllowFlowControl { get; init; }
        public AllowMode AllowClasses { get; init; }
        public AllowMode AllowStructs { get; init; }
        public AllowMode AllowInterfaces{ get; init; }
        public AllowMode AllowProperties { get; init; }
        public AllowMode AllowPublicFields { get; init; }
        public AllowMode AllowPrivateFields { get; init; }
        public AllowMode AllowConstants { get; init; }

        public ProgrammingStandard(string languageName)
        {
            this.LanguageName = languageName;
        }
    }
}
