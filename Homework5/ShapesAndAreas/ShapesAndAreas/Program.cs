// Caitlin Sheeran
// 2/24/2025

using System.Drawing;

namespace ShapesAndAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle("Red", 6, 6);
            Circle cirle1 = new Circle("Blue", 7);

            Console.WriteLine(rectangle1);
            Console.WriteLine(cirle1);
        }
    }
    public abstract class Shape
    {
        private string color = "n/a";

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public Shape(string aColor)
        {
            this.color = aColor;
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Color: {this.Color}\t";
            return msg;
        }
    }


    public class Rectangle : Shape
    {
        private int width = -1;
        private int height = -1;

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public Rectangle(string aColor, int aWidth, int aHeight) : base(aColor)
        {
            this.width = aWidth;
            this.height = aHeight;
        }
        public int GetArea()
        {
            return this.width * this.height;
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Color: {this.Color}\t";
            msg += $"Width: {this.Width}\t";
            msg += $"Height: {this.Height}\t";
            msg += $"Area: {GetArea()}\t";
            return msg;
        }
    }


    public class Circle : Shape
    {
        private double radius = -1;

        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }
        public Circle(string aColor, int aRadius) : base(aColor)
        {
            this.radius = aRadius;
        }
        public double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Color: {this.Color}\t";
            msg += $"Radius: {this.Radius}\t";
            msg += $"Area: {GetArea()}\t";
            return msg;
        }
    }

}
