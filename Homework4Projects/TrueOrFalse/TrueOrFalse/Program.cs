// Caitlin Sheeran
// 2/16/2025



namespace TrueOrFalse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InOrder userInput = new InOrder();
            Console.WriteLine(userInput.CheckInOrder("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(userInput.CheckInOrder("123456789"));
            Console.WriteLine(userInput.CheckInOrder("gkkjdhb"));

        }
    }
    public class InOrder
    {
        public bool CheckInOrder(string word)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] < word[i - 1])
                    return false; 
            }
            return true; 
        }
    }
}
