// Caitlin Sheeran
// 3/16/2025

namespace SaferNumberCrunching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter a whole number: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int value)) {
                    Console.WriteLine($"You entered {value}");
                    break;
                }
                else Console.WriteLine("That is not a whole number");
            }
            while (true)
            {
                Console.Write("Please enter a number with a decimal: ");
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double value))
                {
                    Console.WriteLine($"You entered {value}");
                    break;
                }
                else Console.WriteLine("That is not a number with a decimal");
            }
            while (true)
            {
                Console.Write("Please enter true or false: ");
                string? input = Console.ReadLine();
                if (bool.TryParse(input, out bool value))
                {
                    Console.WriteLine($"You entered {value}");
                    break;
                }
                else Console.WriteLine("That is not true or false");
            }


        }
    }
}
