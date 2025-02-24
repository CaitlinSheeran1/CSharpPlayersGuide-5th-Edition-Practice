// Caitlin Sheeran
// 2/24/2025


using Microsoft.VisualBasic;

namespace VehiclesAndCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Fussion", 2016, 4);
            Motorcycle motorcycle1 = new Motorcycle("Harley", "Big Wheel", 1990, true);
            Console.WriteLine(car1);
            Console.WriteLine(motorcycle1);
        }
    }
    public class Vehicle
    {
        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public Vehicle(string aMake, string aModel, int aYear)
        {
            this.make = aMake;
            this.model = aModel;
            this.year = aYear;
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Year: {this.Year}\t";
            msg += $"Make: {this.Make}\t";
            msg += $"Model: {this.Model}\t";
            return msg;
        }
    }
    public class Car : Vehicle
    {
        private int numberOfDoors = -1;
        
        public int NumberOfDoors
        {
            get { return this.numberOfDoors; }
            set { this.numberOfDoors = value; }
        }
        public Car(string aMake, string aModel, int aYear, int aNumberOfDoors) :base(aMake, aModel, aYear)
        {
            this.NumberOfDoors = aNumberOfDoors;
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Year: {this.Year}\t";
            msg += $"Make: {this.Make}\t";
            msg += $"Model: {this.Model}\t";
            msg += $"\tNumber of Doors: {this.NumberOfDoors}\t";
            return msg;
        }
    }
    public class Motorcycle : Vehicle
    {
        private bool hasSidecar = false;

        public bool HasSidecar
        {
            get { return this.hasSidecar; }
            set { this.hasSidecar = value; }
        }
        public Motorcycle(string aMake, string aModel, int aYear, bool aHasSidecar) :base(aMake, aModel, aYear)
        {
            this.hasSidecar = aHasSidecar;
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Year: {this.Year}\t";
            msg += $"Make: {this.Make}\t";
            msg += $"Model: {this.Model}\t";
            msg += $"Number of Doors: {this.HasSidecar}\t";
            return msg;
        }

    }
}
