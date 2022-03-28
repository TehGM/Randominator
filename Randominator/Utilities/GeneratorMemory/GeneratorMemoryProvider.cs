namespace TehGM.Randominator.Utilities.GeneratorMemory.Services
{
    public class GeneratorMemoryProvider : IGeneratorMemoryProvider
    {
        private readonly IDictionary<string, IGeneratorMemory> _containers;
        private readonly ILogger _log;

        public GeneratorMemoryProvider(ILogger<GeneratorMemoryProvider> log)
        {
            this._log = log;
            this._containers = new Dictionary<string, IGeneratorMemory>();
        }

        public void Add(string key, IGeneratorMemory container)
        {
            lock (this._containers)
            {
                this._log.LogDebug("Adding a new generator memory container with key {Key}", key);
                this._containers.Add(key, container);
            }
        }

        public IGeneratorMemory Get(string key)
        {
            lock (this._containers)
            {
                this._log.LogTrace("Looking up generator memory container with key {Key}", key);
                if (this._containers.TryGetValue(key, out IGeneratorMemory container))
                    return container;
                else
                    throw new KeyNotFoundException($"Generator memory with key '{key}' not found");
            }
        }

        public void Remove(string key)
        {
            lock (this._containers)
            {
                this._log.LogDebug("Removing a generator memory container with key {Key}", key);
                if (!this._containers.TryGetValue(key, out IGeneratorMemory container))
                    return;
                container.Clear();
                this._containers.Remove(key);
            }
        }

        public void Clear()
        {
            lock (this._containers)
            {
                this._log.LogDebug("Clearing all generator memory containers");
                foreach (IGeneratorMemory container in this._containers.Values)
                    container.Clear();
                this._containers.Clear();
            }
        }
    }
}
