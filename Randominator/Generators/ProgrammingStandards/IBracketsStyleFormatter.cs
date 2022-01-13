namespace TehGM.Randominator.Generators.ProgrammingStandards
{
    public interface IBracketsStyleFormatter
    {
        string Apply(string beforeBrackets, string withinBrackets, BracketsStyle style);
    }
}
