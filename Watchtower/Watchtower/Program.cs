// Caitlin Sheeran
// 1/20/2025



namespace Watchtower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for an x value then coverts the value to an int
            Console.Write("What is the x value of the enemy?: ");
            string inputX = Console.ReadLine();
            int xValue = Convert.ToInt32(inputX);

            // Ask the user for an y value then coverts the value to an int
            Console.Write("What is the y value of the enemy?: ");
            string inputY = Console.ReadLine();
            int yValue = Convert.ToInt32(inputY);



            if (xValue < 0) // Reads that the x value is less then 0 then looks for a condition for y
            {
                if (yValue > 0)
                    Console.WriteLine("The enemy is Northwest!");
                else if (yValue == 0)
                    Console.WriteLine("The enemy is West!");
                else
                    Console.WriteLine("The enemy is Southwest!");
            }
            else if (xValue == 0) // Reads that the x value is equal then 0 then looks for a condition for y
            {
                if (yValue > 0)
                    Console.WriteLine("The enemy is North!");
                else if (yValue == 0)
                    Console.WriteLine("The enemy is in the middle!");
                else
                    Console.WriteLine("The enemy is South!");
            }
            else // Reads that the x value is more then 0 then looks for a condition for y
            {
                if (yValue > 0)
                    Console.WriteLine("The enemy is Northeast!");
                else if (yValue == 0)
                    Console.WriteLine("The enemy is East!");
                else
                    Console.WriteLine("The enemy is Southeast!");
            }

        }
    }
}
