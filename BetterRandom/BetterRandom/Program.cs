// Caitlin Sheeran
// 3/16/2025

using BetterRandom;

namespace BetterRandom
{
    public static class RandomClass
    {
        public static double NextDouble(this Random random, double maximum)
        {
            return random.NextDouble() * maximum;
        }

        public static string NextString(this Random random, params string[] options)
        {
            return options[random.Next(options.Length)];
        }

        public static bool CoinFlip(this Random random, double probabilityOfHeads = 0.5)
        {
            return random.NextDouble() < probabilityOfHeads;
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine(random.NextDouble(100));
        Console.WriteLine(random.NextString("Red", "Green", "Blue")); 
        Console.WriteLine(random.CoinFlip()); 
        Console.WriteLine(random.CoinFlip(0.75));
    }
}