using System.Collections;

namespace TehGM.Randominator.Utilities.GeneratorMemory.Services
{
    public class GeneratorMemoryContainer<TItem> : IGeneratorMemory<TItem>, IGeneratorMemory, IEnumerable<TItem>, ICollection<TItem>, ICollection, IEquatable<GeneratorMemoryContainer<TItem>>
    {
        public string Key { get; }
        public int MaxHistoryItems
        {
            get => this._maxHistoryItems;
            set
            {
                this._maxHistoryItems = value;
                this.TrimCollection();
            }
        }
        public IEnumerable<TItem> HistoryItems => this._historyItems ?? Enumerable.Empty<TItem>();

        private Queue<TItem> _historyItems;
        private int _maxHistoryItems;

        public GeneratorMemoryContainer(string key, int maxItems)
        {
            this.Key = key;
            this.MaxHistoryItems = maxItems;
        }

        public GeneratorMemoryContainer(string key)
            : this(key, -1) { }

        public void AddItem(TItem item)
        {
            this._historyItems ??= new Queue<TItem>(this.MaxHistoryItems);
            this._historyItems.Enqueue(item);
            this.TrimCollection();
        }

        private void TrimCollection()
        {
            if (this._historyItems == null)
                return;
            if (this.MaxHistoryItems < 0)
                return;
            while (this._historyItems.Count > this.MaxHistoryItems)
                this._historyItems.Dequeue();
        }

        public void Clear()
        {
            this._historyItems.Clear();
            this._historyItems.TrimExcess();
        }

        #region Equality
        public override bool Equals(object obj)
            => this.Equals(obj as GeneratorMemoryContainer<TItem>);
        public bool Equals(GeneratorMemoryContainer<TItem> other)
            => other != null && this.Key == other.Key;
        public override int GetHashCode()
            => HashCode.Combine(this.Key);
        #endregion

        #region Interfaces Implementation
        // IEnumerable
        public IEnumerator<TItem> GetEnumerator()
            => this.HistoryItems.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => this.HistoryItems.GetEnumerator();
        // ICollection<T>
        int ICollection<TItem>.Count => this._historyItems.Count;
        bool ICollection<TItem>.IsReadOnly => ((ICollection<TItem>)this._historyItems).IsReadOnly;
        void ICollection<TItem>.Add(TItem item)
            => this.AddItem(item);
        bool ICollection<TItem>.Contains(TItem item)
            => this._historyItems.Contains(item);
        void ICollection<TItem>.CopyTo(TItem[] array, int arrayIndex)
            => this._historyItems.CopyTo(array, arrayIndex);
        bool ICollection<TItem>.Remove(TItem item)
            => ((ICollection<TItem>)this._historyItems).Remove(item);
        // ICollection
        int ICollection.Count => this._historyItems.Count;
        bool ICollection.IsSynchronized => ((ICollection)this._historyItems).IsSynchronized;
        object ICollection.SyncRoot => ((ICollection)this._historyItems).SyncRoot;
        void ICollection.CopyTo(Array array, int index)
            => ((ICollection)this._historyItems).CopyTo(array, index);
        #endregion
    }
}
