// Caitlin Sheeran
// 2/16/2025


using System.Security.Cryptography.X509Certificates;

namespace FirstAndLastCharSwapped
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Swap word = new Swap();

            Console.WriteLine(word.SwapCharacters("Apple"));
            Console.WriteLine(word.SwapCharacters("z"));
            Console.WriteLine(word.SwapCharacters("anna"));



        }
    }
    public class Swap
    {
        public string SwapCharacters(string Word)
        {
            char char1;
            char char2;

            if (Word.Length > 2)
            {
                if (Word[0] != Word[Word.Length - 1])
                {
                    char1 = Word[0];
                    char2 = Word[Word.Length - 1];

                    char[] wordArray = Word.ToCharArray();

                    wordArray[0] = char2;
                    wordArray[Word.Length - 1] = char1;

                    return new string(wordArray);

                }
                else return "Two's a pair.";
            }
            else return "Incompatible.";


        }
    }

}
   
