// Caitlin Sheeran
// 2/16/2025


namespace FirstNVowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstVowels newSentance = new FirstVowels();
            Console.WriteLine(newSentance.VowelCount("sharpening skills", 3));
            Console.WriteLine(newSentance.VowelCount("major league", 5));
            Console.WriteLine(newSentance.VowelCount("hostess", 5));
        }
    }
    public class FirstVowels
    {
        public string VowelCount(string Sentance, int Number)
        {
            int vowels = 0;
            List<char> sentanceVowels = new List<char> { };

            foreach (char i in Sentance)
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    vowels++;
                    sentanceVowels.Add(i);


                    if (vowels == Number)
                        break;
                }
            }


            if (vowels < Number)
            {
                return "invalid";
            }


            return new string(sentanceVowels.ToArray()); ;
        }
    }
}
