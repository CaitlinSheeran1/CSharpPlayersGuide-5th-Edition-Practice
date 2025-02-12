// Caitlin Sheeran
// 2/4/2025


using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;

namespace TheCard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creates a list for both Color and Rank enum values
            List<Color> colors = new List<Color> { Color.Red, Color.Yellow, Color.Green, Color.Blue };
            List<Rank> ranks = new List<Rank> { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five,
                                                Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten,
                                                Rank.Dollar, Rank.Percent, Rank.Caret, Rank.Ampersand };


            // prints a rank for each color
            foreach (Color i in colors)
            {
                foreach (Rank j in ranks)
                {
                    Card card = new Card(i, j);
                    Console.WriteLine(card);
                }
            }



            Console.ReadKey();
        }
    }
    public class Card
    {
        // private fields
        private Color cardColor = Color.None;
        private Rank cardRank = Rank.None;

        // gets and sets
        public Color CardColor
        {
            get { return this.cardColor; }
            set { this.cardColor = value; }
        }
        public Rank CardRank
        {
            get { return this.cardRank; }
            set { this.cardRank = value; }
        }

        // Constructor
        public Card(Color aCardColor, Rank aCardRank)
        {
            this.cardColor = aCardColor;
            this.cardRank = aCardRank;
        }

        // Method
        public override string ToString()
        {
            string msg = "";
            msg += $"The {this.CardColor} {this.CardRank}";
            return msg;
        }





    }

    // enums
   public enum Color { None, Red, Green, Blue, Yellow };
   public  enum Rank { None, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand };
}
