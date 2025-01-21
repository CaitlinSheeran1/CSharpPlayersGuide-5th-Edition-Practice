//Caitlin Sheeran
//1/18/2025

// String answer;
// answer = Console.ReadLine();    - user input

namespace FirstProjectGuide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            string a = Console.ReadLine();  //User inputs an asnwer to the question above
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b = Console.ReadLine(); //User describes the answer they gave in the first question
            string c = "Doom"; // A string text that is added later with user answers
            string d = "3000"; // A string text that is added later with user answers
            Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");


           
            
        }
    }
}
