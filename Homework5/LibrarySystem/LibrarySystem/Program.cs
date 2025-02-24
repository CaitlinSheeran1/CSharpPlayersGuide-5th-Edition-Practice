// Caitlin Sheeran
// 2/24/2025

//1.Create a base class called Book with:
//o Properties for Title, Author, and YearPublished.
//o	A constructor to initialize these properties.
//o	An overridden ToString() method that returns "Title by Author (YearPublished)".

//2.	Create two subclasses, EBook and PrintedBook, that inherit from Book.
//o	EBook should have an additional property FileSizeMB.
//o	PrintedBook should have an additional property PageCount.
//o	Each subclass should override ToString() so that EBook includes the file size and PrintedBook includes the number of pages.


namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public abstract class Animal
    {
        private string name = "n/a";

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Animal(string aName)
        {
            this.name = aName;
        }
        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Name: {this.Name}\t";
            msg += $"Sound: {MakeSound()}\t";
            return msg;
        }
    }


    public class Dog : Animal
    {
        public Dog(string aName) : base(aName)
        {
        }

        public override string MakeSound()
        {
            return "Bark";
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Name: {this.Name}\t";
            msg += $"Sound: {MakeSound()}\t";
            return msg;
        }
    }
    



}
