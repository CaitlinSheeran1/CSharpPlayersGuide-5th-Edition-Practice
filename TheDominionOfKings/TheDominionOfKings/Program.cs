// Caitlin Sheeran
// 1/20/2025


namespace TheDominionOfKings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0; // total points the playe will have
            
            //This block of code will ask and calcaute points based on how many provinces you have
            Console.WriteLine("Enter how many provinces you have");
            string inputProvinces = Console.ReadLine();
            int provinces = Convert.ToInt32(inputProvinces);
            points += provinces;
                        
            //This block of code will ask and calcaute points based on how many duchies you have
            Console.WriteLine("Enter how many duchies you have");
            string inputDuchies = Console.ReadLine();
            int duchies = Convert.ToInt32(inputDuchies);
            points += duchies * 3;

            //This block of code will ask and calcaute points based on how many estates you have
            Console.WriteLine("Enter how many estates you have");
            string inputEstates = Console.ReadLine();
            int estates = Convert.ToInt32(inputEstates);
            points += estates * 6;

            // Displays the amount of points you have
            Console.WriteLine("Your total amount of points is "+ points);




        }
    }
}
