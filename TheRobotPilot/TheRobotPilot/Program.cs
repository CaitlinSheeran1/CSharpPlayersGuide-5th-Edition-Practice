// Caitlin Sheeran
// 3/16/2025

namespace TheRobotPilot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            int manticoreHealth = 10;
            int cityHealth = 15;
            int roundNumber = 1;

            Console.ForegroundColor = ConsoleColor.White;
            Random random = new Random();
            int manticoreLocationNumber = random.Next(1, 101);
            

            // a while loop that will run until either manticore or city health reaches zero
            while (manticoreHealth > 0 && cityHealth > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n---------------------------------");
                Console.WriteLine($"STATUS: Round: {roundNumber} City: {cityHealth}/15 Manticore: {manticoreHealth}/10"); // Displays the round number, city health, and manticore health

                Console.ForegroundColor = ConsoleColor.Yellow;
                int damage = damageAmount(roundNumber);
                Console.WriteLine($"The cannon is expected to deal {damage} this round."); // Tells player two how much damage they could do

                Console.ForegroundColor = ConsoleColor.White;
                int userGuess = numberInRange("Enter desired canon range: ", 0, 100); // Asks player two to pick a number

                numberGuess(userGuess, manticoreLocationNumber);


                // If user guesses number it takes away helaht based on damage number
                if (userGuess == manticoreLocationNumber) { manticoreHealth -= damage; }

                // Takes away one health for every round to city
                if (manticoreHealth > 0) { cityHealth -= 1; }

                // increases round number
                roundNumber++;


            }

            // METHODS


            // Displays if manticore reaches 0
            if (manticoreHealth <= 0 && cityHealth > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThe Manticore has been destoryed! The city of Consolas has been saved!");
            }

            // Displays if city reaches zero
            if (cityHealth <= 0 && manticoreHealth > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThe city of Consolas has been destroyed! The Manticore has won!");
            }



            // Tells user if they guesse the number, guessed too high or too low
            void numberGuess(int userGuess, int manticoreLocationNumber)
            {
                if (userGuess == manticoreLocationNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That round was a DIRECT HIT!");

                }
                else if (userGuess > manticoreLocationNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That round OVERSHOT the target");

                }
                else if (userGuess < manticoreLocationNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That round FELLSHORT the target");

                }

            }



            // returns amount of damage based on round number
            int damageAmount(int round)
            {

                if (round % 3 == 0 && round % 5 == 0)
                {
                    return 10;
                }
                else if (round % 3 == 0 || round % 5 == 0)
                {
                    return 3;
                }
                else return 1;
            }


            // Converts user answer to an int
            int askForNumber(string text)
            {
                Console.Write(text + " ");
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }


            // Makes sure user picks a number between 0 and 100
            int numberInRange(string text, int min, int max)
            {
                while (true)
                {
                    int number = askForNumber(text);
                    if (number > min && number < max)
                    {
                        return number;
                    }
                }
            }

        }
    }
}
