namespace TehGM.Randominator.Generators.UniqueID.Services
{
    public class UniqueIdGenerator : IUniqueIdGenerator
    {
        private readonly ILogger _log;

        public UniqueIdGenerator(ILogger<UniqueIdGenerator> log)
        {
            this._log = log;
        }

        public UniqueIdValue Generate()
        {
            this._log.LogTrace("Generating a new Unique ID");
            Guid value = Guid.NewGuid();
            UniqueIdValue result = new UniqueIdValue(value);
            this._log.LogDebug("Generated Unique ID: {ID}", value);
            return result;
        }
    }
}
