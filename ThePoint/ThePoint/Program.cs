// Caitlin Sheeran
// 2/4/2025



using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;
using Microsoft.VisualBasic;

namespace ThePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // creates two new points with their variables
            Point point1 = new Point(2, 3);
            Point point2 = new Point(-4, 0);

            Console.WriteLine(point1);
            Console.WriteLine(point2);



            Console.ReadKey();
        }
    }

    // Point class
    public class Point
    {
        // class fields
        private int x = -1;
        private int y = -1;

        // gets and sets
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        // constructor
        public Point(int aX, int aY)
        {
            this.x = aX;
            this.y = aY;
        }

        // Methods
        public override string ToString()
        {
            string msg = "";
            msg += msg + $"({this.X}, {this.Y})";
            return msg;

        }
    }

    
}
