// Caitlin Sheeran
// 1/20/2025


namespace RepairingTheClocktower
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ask user for a number then coverts the string into an int
            Console.Write("Enter an number: ");
            string inputNumber = Console.ReadLine();
            int number = Convert.ToInt32(inputNumber);

            //If the number from input is even, then tick is displayed, otherwise a tock is displayed
            if (number % 2 == 0)
                Console.WriteLine("TICK");
            else
                Console.WriteLine("TOCK");



        }
    }
}
