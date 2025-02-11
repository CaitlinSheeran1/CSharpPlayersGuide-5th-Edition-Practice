// Caitlin Sheeran
// 2/4/2025


using System.Net.Http.Headers;
using System.Xml;

namespace TheColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assining two variables
            Color user1 = new Color(255, 255, 255);
            Color user2 = Color.OrangeColor();

            //Displays the color information
            Console.WriteLine($"This is added numbers: { user1}");
            Console.WriteLine($"This is calling for a color itself: {user2}");

            Console.ReadKey();
        }
    }

    public class Color
    {
        // class fields
        private int red = -1;
        private int green = -1;
        private int blue = -1;

        // gets and sets
        public int Red
        {
            get { return this.red; }
            set { this.red = value; }
        }
        public int Green
        {
            get { return this.green; }
            set { this.green = value; }
        }
        public int Blue
        {
            get { return this.blue; }
            set { this.blue = value; }
        }

        public Color(int aRed, int aGreen, int aBue)
        {
            this.red = aRed;
            this.green = aGreen;
            this.blue = aBue;
        }

        // methods
        public override string ToString()
        {
            string msg = "";
            msg += "Red: " + this.Red + "\n";
            msg += "Green: " + this.Green + "\n";
            msg += "Blue: " + this.Blue + "\n";
            return msg;
        }

        public static Color WhiteColor()
        {
            return new Color(255, 255, 255);
        }
        public static Color BlackColor()
        {
            return new Color(0, 0, 0);
        }
        public static Color RedColor()
        {
            return new Color(255, 0, 0);
        }
        public static Color OrangeColor()
        {
            return new Color(255, 165, 0);
        }
        public static Color YellowColor()
        {
            return new Color(255, 255, 0);
        }
        public static Color GreenColor()
        {
            return new Color(0, 128, 0);
        }
        public static Color BlueColor()
        {
            return new Color(0, 0, 255);
        }
        public static Color PurpleColor()
        {
            return new Color(128, 0, 128);
        }

    }
    
}
