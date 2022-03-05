namespace TehGM.Randominator.Utilities.GeneratorMemory
{
    public interface IGeneratorMemory
    {
        void Clear();
    }

    public interface IGeneratorMemory<TItem> : IGeneratorMemory
    {
        int MaxHistoryItems { get; set; }
        IEnumerable<TItem> HistoryItems { get; }
        void AddItem(TItem item);
    }
}
