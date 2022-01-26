namespace TehGM.Randominator.Utilities
{
    public interface IClipboard
    {
        ValueTask WriteTextAsync(string text, CancellationToken cancellationToken = default);
    }
}
