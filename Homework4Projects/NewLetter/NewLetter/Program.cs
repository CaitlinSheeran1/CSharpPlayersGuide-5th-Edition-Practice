// Caitlin Sheeran
// 2/16/2025

namespace NewLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NextLetter word = new NextLetter();
            Console.WriteLine(word.GetNextLetter("hello"));
            Console.WriteLine(word.GetNextLetter("bye"));
            Console.WriteLine(word.GetNextLetter("welcome"));
        }
    }
    public class NextLetter
    {
        public string GetNextLetter(string Word)
        {
            char[] letters = Word.ToCharArray(); 

            for (int i = 0; i < letters.Length - 1; i++)
            {
                letters[i] = (char)(letters[i] + 1); 
            }

            letters[letters.Length - 1] = (char)(letters[letters.Length - 1] + 1);

            return new string(letters);
        }
    }
}
