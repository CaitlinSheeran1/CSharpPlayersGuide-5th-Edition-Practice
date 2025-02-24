// Caitlin Sheeran
// 2/24/2025

namespace AnimalsAndSounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Gilbert");
            Dog dog1 = new Dog("Laberder");
            Console.WriteLine(cat1);
            Console.WriteLine(dog1);
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
    public class Cat : Animal
    {
        public Cat(string aName) : base(aName)
        {
        }

        public override string MakeSound()
        {
            return "Meow";
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
