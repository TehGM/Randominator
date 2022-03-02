using TehGM.Randominator.Services;

namespace TehGM.Randominator.Utilities.Services
{
    public class RandomizerProvider : IRandomizerProvider
    {
        private readonly IRandomizer _sharedRandomizer;

        public RandomizerProvider()
        {
            this._sharedRandomizer = new RandomizerService();
        }

        public IRandomizer GetSharedRandomizer()
            => this._sharedRandomizer;

        public IRandomizer GetRandomizerWithSeed(Seed seed)
            => new RandomizerService(seed);
    }
}
