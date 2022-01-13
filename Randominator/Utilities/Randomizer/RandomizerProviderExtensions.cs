namespace TehGM.Randominator.Utilities
{
    public static class RandomizerProviderExtensions
    {
        public static IRandomizer GetRandomizerWithSeed(this IRandomizerProvider provider, string seed)
        {
            if (seed == null)
                throw new ArgumentNullException(nameof(seed));
            return provider.GetRandomizerWithSeed(seed.GetHashCode());
        }
    }
}
