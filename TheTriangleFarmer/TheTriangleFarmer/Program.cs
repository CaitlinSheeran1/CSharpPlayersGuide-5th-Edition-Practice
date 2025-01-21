//Caitlin Sheeran
//1/18/2025


namespace TheTriangleFarmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the base of the triangle: ");
            string baseInput = Console.ReadLine();
            int triangleBase = Convert.ToInt32(baseInput);

            Console.WriteLine("Please enter the height of the triangle");
            string heightInput = Console.ReadLine();
            int triangleHeight = Convert.ToInt32(heightInput);


            double triangleArea = (triangleBase * triangleHeight) / 2;

            Console.WriteLine("The area of your triangle is: " + triangleArea);



        }
    }
}
