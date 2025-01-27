// Caitlin Sheeran
// 1/22/2025


namespace TheReplicatorOfDTo
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int[] numbers = new int[5]; // Declaring the array as numbers with a length of 5

            // This for loop will run 5 times asking the user for 5 numbers
            // then updating them to the numbers array
            for (int index = 0; index < 5; index++)
            {
                Console.Write("Please give an number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[index] = number;
            }


            int[] newNumbers = new int[5]; // Declaring a sexonf array as newNumbers with a length of 5


            // This for loop runs 5 times copying the numbers from the first array into the second
            for (int index = 0; index < 5; index++)
            {
                newNumbers[index] = numbers[index];
            }

            // This for loop will run 5 times displaying bot the new numbers and the orginal numbers
            for (int index =0; index < 5; index++)
            {
                Console.WriteLine($"The first number is {numbers[index]} and the copy number is {newNumbers[index]}");
            }



                
            


            

        }
    }
}
