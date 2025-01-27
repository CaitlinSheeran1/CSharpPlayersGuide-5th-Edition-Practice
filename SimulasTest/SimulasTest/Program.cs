// Caitlin Sheeran
// 1/26/2025


using System.Data;

namespace SimulasTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for the while loop to remain true
            bool isRunning = true;

            // sets the default value of the ChestState to locked
            ChestState state = ChestState.locked;



            while (isRunning)
            {
                // Prompts the user with the state of the chest and what they would like to do
                Console.Write($"The chest is {state}. What would you like to do? ");

                // gets user input and stores it under userInput
                string userInput = Console.ReadLine();

                // Checks what the user has typed in and compares it to the state of the chest
                if (state == ChestState.open && userInput == "close") state = ChestState.closed;
                else if (state == ChestState.closed && userInput == "lock") state = ChestState.locked;
                else if (state == ChestState.locked && userInput == "unlock") state = ChestState.closed;
                else if (state == ChestState.closed && userInput == "open") state = ChestState.open;
                else Console.WriteLine("You need to select either lock, unlock, open, or close. \n");


            }
            
        }

        // The enumeration
        enum ChestState { locked, unlock, open, closed }
    }
}
