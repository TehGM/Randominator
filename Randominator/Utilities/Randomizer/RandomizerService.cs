namespace TehGM.Randominator.Services
{
    internal class RandomizerService : IRandomizer
    {
        private readonly Random _random;

        public RandomizerService()
        {
            this._random = new Random();
        }

        public RandomizerService(int seed)
        {
            this._random = new Random(seed);
        }

        public int GetRandomNumber(int min, int max, bool inclusive)
        {
            max = inclusive ? ++max : max;
            return _random.Next(min, max);
        }

        public double GetRandomNumber(double min, double max)
        {
            double range = max - min;
            return min + _random.NextDouble() * range;
        }
    }
}
