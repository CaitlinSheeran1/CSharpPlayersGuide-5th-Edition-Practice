// Caitlin Sheeran
// 1/20/2025


namespace TheDefenseOfConsolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to write a number for the row then converts into an int
            Console.Write("Target Row? ");
            string inputRow = Console.ReadLine();
            int row = Convert.ToInt32(inputRow);

            // Ask user to write a number for the column then converts into an int
            Console.Write("Target Column? ");
            string inputColumn = Console.ReadLine();
            int column = Convert.ToInt32(inputColumn);

            // Displays the 4 different columns and rows based on user's input
            Console.WriteLine("Deploy to:");
            Console.WriteLine($"{row}, {column - 1}");
            Console.WriteLine($"{row - 1}, {column}");
            Console.WriteLine($"{row}, {column + 1}");
            Console.WriteLine($"{row + 1}, {column}");
            Console.Beep(500, 2000);
        }
    }
}
