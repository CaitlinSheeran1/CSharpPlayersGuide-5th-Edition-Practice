// Caitlin Sheeran
// 1/22/2025


namespace Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Countdown(10); // The number given to start counting down from


            void Countdown(int number) // The method that will be counting down the number
            {
                if (number == 0) return; // Once the number reaches zero, it will return nothing
                Console.WriteLine(number);
                Countdown(number - 1); //Calls back to it's own method will subtracting 1 from the parameter given
            }
        }
    }
}
