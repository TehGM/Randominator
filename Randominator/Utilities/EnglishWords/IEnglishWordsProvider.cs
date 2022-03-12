namespace TehGM.Randominator.Utilities
{
    public interface IEnglishWordsProvider
    {
        public Task<IEnumerable<string>> GetVerbsAsync(CancellationToken cancellationToken = default);
        public Task<IEnumerable<string>> GetNounsAsync(CancellationToken cancellationToken = default);
        public Task<IEnumerable<string>> GetAdjectivesAsync(CancellationToken cancellationToken = default);
        public Task<IEnumerable<string>> GetAdverbsOfMannerAsync(CancellationToken cancellationToken = default);
    }
}
