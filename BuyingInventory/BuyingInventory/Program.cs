// Caitlin Sheeran
// 1/20/2025

namespace BuyingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Displays the items the user is able to check the price off
            Console.WriteLine("The following items are available:");
            Console.WriteLine($"1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water");
            Console.WriteLine($"5 - Machete\n6 - Canoe\n7 - Food Supplies");
            Console.Write("What number do you want to see the price of? ");
            int userChoice = Convert.ToInt32( Console.ReadLine() ); // Coverts user answer into an int

            string response; //Creates the string needed for the switch statement


            // The number the user typed will be matched with an option below and displayed
            response = userChoice switch
            {
                1 => "Rope is 10 gold,",
                2 => "Torches are 15 gold.",
                3 => "Climbing gear is 25 gold.",
                4 => "Clean Water is 1 gold",
                5 => "Machete is 20 gold",
                6 => "Canoe is 200 gold",
                7 => "Food Supplies is 1 gold.",
                _ => "Invalid choice"
            };

            Console.WriteLine(response);



        }
    }
}
