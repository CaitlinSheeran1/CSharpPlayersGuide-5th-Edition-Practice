// Caitlin Sheeran
// 9/25/25

namespace TheLongGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            Console.Write("What is your name: "); string name = Console.ReadLine();

            if (File.Exists($"{name}.txt"))
            {
                string b = File.ReadAllText($"{name}.txt");
                string[] tokens = b.Split(',');

                name = tokens[0];
                points = Convert.ToInt32(tokens[1]);
            }

            
            while (true)
            {
                Console.WriteLine($"{name}: {points} points");

                var a = Console.ReadKey(true);
                if (a.Key == ConsoleKey.Enter)
                {
                    string info = ($"{name},{points}");
                    File.WriteAllText($"{name}.txt", info);
                    Environment.Exit(0);
                }
                else points++;
            }
        }
    }
}
