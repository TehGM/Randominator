namespace TehGM.Randominator
{
    internal static class RandomizerExtensions
    {
        public static T GetRandomValue<T>(this IRandomizer randomizer, IEnumerable<T> values)
        {
            ThrowIfNullOrEmpty(values);
            int max = values.Count();
            int index = randomizer.GetRandomNumber(0, max, inclusive: false);
            return values.ElementAt(index);
        }

        public static double GetRandomChance(this IRandomizer randomizer)
            => randomizer.GetRandomNumber(0.0d, 1.0d);

        public static bool RollChance(this IRandomizer randomizer, double chance)
            => randomizer.GetRandomChance() <= chance;

        private static void ThrowIfNullOrEmpty<T>(IEnumerable<T> values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));
            if (!values.Any())
                throw new ArgumentException("Values set must contain at least one value.", nameof(values));
        }
    }
}
