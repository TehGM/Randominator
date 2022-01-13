namespace TehGM.Randominator
{
    public interface IRandomizer
    {
        /// <summary>Gets a random integer.</summary>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maximum value.</param>
        /// <param name="inclusive">Whether <paramref name="max"/> is inclusive.</param>
        /// <returns>A randomly generated number.</returns>
        int GetRandomNumber(int min, int max, bool inclusive = false);
        /// <summary>Gets a random double.</summary>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maximum value.</param>
        /// <returns>A randomly generated number.</returns>
        double GetRandomNumber(double min, double max);
    }
}
