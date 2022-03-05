namespace TehGM.Randominator.Utilities.GeneratorMemory
{
    public interface IGeneratorMemoryProvider
    {
        void Add(string key, IGeneratorMemory container);
        IGeneratorMemory Get(string key);
        void Remove(string key);
        void Clear();
    }
}
