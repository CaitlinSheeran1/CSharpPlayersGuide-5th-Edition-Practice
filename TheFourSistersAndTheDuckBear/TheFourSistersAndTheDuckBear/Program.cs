//Caitlin Sheeran
//1/18/2025


namespace TheFourSistersAndTheDuckBear
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter the amount of chocalte eggs you have:");
            string eggInput = Console.ReadLine();
            int amountOfEggs = Convert.ToInt32(eggInput);

            int eggsPerSister = amountOfEggs / 4;
            int eggRemainder = amountOfEggs % 4;

            Console.WriteLine("Each sister will have " + eggsPerSister + "eggs and there will be " + eggRemainder + "eggs left over");


        }
    }
}
