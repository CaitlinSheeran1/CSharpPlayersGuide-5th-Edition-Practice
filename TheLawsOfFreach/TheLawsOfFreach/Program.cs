namespace TheLawsOfFreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //An array that has 9 values already assigned to it
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            // This grabs the biggest number using the MaxValue method
            int smallestNumber = int.MaxValue;

            // This foreach runs through each number in the array and finds the smallest one
            foreach (int number in array)
            {
                if (number < smallestNumber)
                    smallestNumber = number;
            }

            // This sets the variable total to 0
            int total = 0;

            // This foreach loop adds all of the numbers to an total
            foreach (int number in array)
            {
                total += number;
            }

            // this finds the average of all of the numbers and assigns it to the float average
            float average = (float)total / array.Length;

            //This sends out and message with the smallest number and the average
            Console.WriteLine($"The smallest number is {smallestNumber} and the average is {average:0.##}");




        }
    }
}
