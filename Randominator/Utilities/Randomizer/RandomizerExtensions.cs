using TehGM.Randominator.Utilities;

namespace TehGM.Randominator
{
    internal static class RandomizerExtensions
    {
        public static IRandomizer GetRandomizerWithSeed(this IRandomizerProvider provider, string seed, bool caseInsensitive = false)
            => provider.GetRandomizerWithSeed(Seed.FromString(seed, caseInsensitive));

        public static T GetRandomValue<T>(this IRandomizer randomizer, IEnumerable<T> values)
        {
            ThrowIfNullOrEmpty(values);
            int max = values.Count();
            int index = randomizer.GetRandomNumber(0, max, inclusive: false);
            return values.ElementAt(index);
        }

        public static double GetRandomChance(this IRandomizer randomizer)
            => randomizer.GetRandomNumber(0.0, 1.0);

        public static bool RollChance(this IRandomizer randomizer, double chance)
            => randomizer.GetRandomChance() <= chance;

        public static bool GetRandomBoolean(this IRandomizer randomizer)
            => randomizer.RollChance(0.5);

        public static T GetRandomEnumValue<T>(this IRandomizer randomizer) where T : struct, Enum
        {
            if (!typeof(T).IsEnum)
                throw new InvalidOperationException($"{nameof(GetRandomEnumValue)} can only be used on enums. {nameof(T)} is not an enum");
            T[] values = Enum.GetValues<T>();
            return randomizer.GetRandomValue(values);
        }

        private static void ThrowIfNullOrEmpty<T>(IEnumerable<T> values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));
            if (!values.Any())
                throw new ArgumentException("Values set must contain at least one value.", nameof(values));
        }
    }
}
