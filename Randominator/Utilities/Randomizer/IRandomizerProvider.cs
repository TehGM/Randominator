namespace TehGM.Randominator.Utilities
{
    public interface IRandomizerProvider
    {
        IRandomizer GetSharedRandomizer();
        IRandomizer GetRandomizerWithSeed(Seed seed);
    }
}
