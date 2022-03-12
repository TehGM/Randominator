namespace TehGM.Randominator.Generators.Dare
{
    public interface IDareGenerator
    {
        Task<string> GenerateAsync(CancellationToken cancellationToken = default);
    }
}
