namespace TehGM.Randominator.Generators.ProgrammingStandards
{
    public interface INamingStyleFormatter
    {
        string ApplyToWord(LetterCaseStyle style, string word, bool isLeading = false);
        string MergeWords(LetterCaseStyle style, IEnumerable<string> words);
    }
}
