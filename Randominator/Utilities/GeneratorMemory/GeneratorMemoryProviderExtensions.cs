using TehGM.Randominator.Utilities.GeneratorMemory.Services;

namespace TehGM.Randominator.Utilities.GeneratorMemory
{
    public static class GeneratorMemoryProviderExtensions
    {
        public static IGeneratorMemory<TItem> Get<TItem>(this IGeneratorMemoryProvider provider, string key)
            => (IGeneratorMemory<TItem>)provider.Get(key);

        public static IGeneratorMemory<TItem> GetOrCreate<TItem>(this IGeneratorMemoryProvider provider, string key)
        {
            try
            {
                return Get<TItem>(provider, key);
            }
            catch (KeyNotFoundException)
            {
                GeneratorMemoryContainer<TItem> container = new GeneratorMemoryContainer<TItem>(key);
                provider.Add(key, container);
                return container;
            }
        }

        public static IEnumerable<TItem> GetGeneratorHistory<TItem>(this IGeneratorMemoryProvider provider, string key)
        {
            IGeneratorMemory<TItem> container = GetOrCreate<TItem>(provider, key);
            return container.HistoryItems;
        }
    }
}
