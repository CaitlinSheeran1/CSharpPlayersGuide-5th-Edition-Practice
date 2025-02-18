// Caitlin Sheeran
// 2/16/2025


namespace ReturnWordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordCount userWord = new WordCount();
            Console.WriteLine(userWord.GetWordCount("Here is a test."));
            Console.WriteLine(userWord.GetWordCount("Apple"));
            Console.WriteLine(userWord.GetWordCount("The very last test will be a super long sentance."));
        }
    }
    public class WordCount
    {
        public string GetWordCount(string Word)
        {
            int wordCount = 0;
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == ' ') wordCount++;

            }
            wordCount += 1;
            return wordCount.ToString();
        }
    }
}
