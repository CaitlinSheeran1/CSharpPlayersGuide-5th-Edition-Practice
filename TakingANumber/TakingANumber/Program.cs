// Caitlin Sheeran
// 1/22/2025



namespace TakingANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This calls for the method AskForNumberInRange and makes sure you picked a number within the range
            int rangeNumber = AskForNumberInRange("Pick a number between 0 and 100: ", 0, 100);
            Console.Clear();

            //Asks the second player to pick a number to guess
            Console.WriteLine("Next person please choose a number");


            while (true) // Tells the player if their guess is too high or too low. Then if they guess the break out of the while true loop
            {
                int guess = AskForNumber("What is the next guess?");
                if (guess > rangeNumber) Console.WriteLine($"{guess} is too high!");
                else if (guess < rangeNumber) Console.WriteLine($"{guess} is too low!");
                else break;
            }

            Console.WriteLine("You guessed it!"); // Only shows up if you break out of the loop (winning)


            int AskForNumber(string text) // This methods converts the user's input into an int from a string
            {
                Console.Write(text + "");
                int result = Convert.ToInt32(Console.ReadLine()) ;
                return result;
            }


            int AskForNumberInRange(string text, int min, int max) // This makes sure the number is within
                                                                   // range of what the user put as min and max
            {
                while (true)
                {
                    int number = AskForNumber(text);
                    if (number >= min && number <= max)
                    {
                        return number;
                    }
                    
                }
            }



        }
    }
}
