/*
 * Caitlin Sheeran 9/23/2025
 * Exepti's Game
 * 
 * */

namespace ExeptisGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // random number object

            int ranNumber = random.Next(10); // picks a random number between 0-9 and store it
            List<int> list = new List<int>();  //list to contain guesses

            while (true)
            {
                try
                {
                    Console.Write("Please choose a number between 0-9: ");
                    int playNum = Convert.ToInt32(Console.ReadLine());

                    
                     if (list.Contains(playNum)) throw new Exception(); //throws an exception if guessed number was already typed
                     else list.Add(playNum);
                    

                    if (playNum == ranNumber) { Console.WriteLine("You guessed it!"); break; } 

                    


                }
                catch ( Exception )
                {
                    Console.WriteLine("That is not a valid number or you already tried that number");
                    break;
                }
            }
        }
    }
}
