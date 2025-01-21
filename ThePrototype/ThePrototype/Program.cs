//Caitlin Sheeran
// 1/21/2025

using System.Data;

namespace ThePrototype
{
    internal class Program
    {
        static void Main(string[] args)


        {   //Asks the user to pick a number between 0-100 and converts it to an int
            Console.Write("Pick a number between 0-100 pilot: ");
            int pilotNumber = Convert.ToInt32(Console.ReadLine());


            bool startingMessage = true; //For the while loop to make sure the number is between 0-100

            // A while loop that won't break until a valid number between 0-100 is entered.
            while (startingMessage) {


                if (pilotNumber < 0 || pilotNumber > 100)
                {
                    Console.WriteLine("Please pick a number between 0-100: ");
                    pilotNumber = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Clear(); //Clears the screen for the next number to be picked
                    startingMessage = false;
                }
            }


            //Asks the second user to pick a number between 0-100 then converts it to an int
            Console.Write("Please guess a number between 0-100 hunter: ");
            int guessingNumber = Convert.ToInt32(Console.ReadLine());


            //for the while loop to guess the number
            bool playingGame = true;


            //A loop that will compare pilotNumber and guessingNumber. User will either get a too high,
            //too low, or a you guessed it messaged based on the number they input
            while (playingGame)
            {
                if (pilotNumber == guessingNumber)
                {
                    Console.WriteLine("You guessed it!");
                    playingGame = false;
                    break;
                }
                else if (guessingNumber > pilotNumber)
                {
                    Console.Write("Too high! Guess again: ");
                    guessingNumber = Convert.ToInt32(Console.ReadLine());
                }
                else if (guessingNumber < pilotNumber)
                {
                    Console.WriteLine("Too low! Guess again: ");
                    guessingNumber = Convert.ToInt32(Console.ReadLine());
                }
                else 
                {
                    Console.Write("Not a valid guess. Pick a number between 0-100: ");
                    pilotNumber = Convert.ToInt32(Console.ReadLine());
                }
            }



        }
    }
}
