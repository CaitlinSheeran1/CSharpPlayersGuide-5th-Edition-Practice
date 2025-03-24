// Caitlin Sheeran
// 2/25/2025

namespace ColoredItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColoredItem<Sword> sword1 = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
            ColoredItem<Bow> bow1 = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
            ColoredItem<Axe> axe1 = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);

            sword1.Display();
            bow1.Display();
            axe1.Display();
        }
    }
    public class Sword { }
    public class Bow { }
    public class Axe { }

    public class ColoredItem<T>
    {
        public T item;
        public ConsoleColor color;
        public T Item
        {
            get { return this.item; }
            set { this.item = value; }
        }
        public ConsoleColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public ColoredItem(T aItem, ConsoleColor aColor)
        {
            this.item = aItem;
            this.color = aColor;
        }
        public void Display()
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine(item);
        }
    }
}
