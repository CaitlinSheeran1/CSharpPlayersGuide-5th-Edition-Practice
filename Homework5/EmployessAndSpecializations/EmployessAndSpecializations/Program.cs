// Caitlin Sheeran
// 2/24/2025

namespace EmployessAndSpecializations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("Mike Dimes", 95000, 30);
            Engineer engineer1 = new Engineer("Jim Jones",73000, "Civil");
            Console.WriteLine(manager1);
            Console.WriteLine(engineer1);
        }
    }
    public class Employee
    {
        private string name = "n/a";
        private int salary = -1;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public Employee(string aName, int aSalary)
        {
            this.name = aName;
            this.salary = aSalary;
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Name: {this.Name}\t";
            msg += $"Salary: {this.Salary}\t";
            return msg;
        }
    }
    public class Manager : Employee
    {
        private int numberOfEmployeesManaged = -1;

        public int NumberOfEmployeesManaged
        {
            get { return this.numberOfEmployeesManaged; }
            set { this.numberOfEmployeesManaged = value; }
        }
        public Manager(string aName, int aSalary,int aNumberOfEmployeesManaged) : base(aName, aSalary)
        {
            this.numberOfEmployeesManaged = aNumberOfEmployeesManaged;
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Name: {this.Name}\t";
            msg += $"Salary: {this.Salary}\t";
            msg += $"Number of Employees Managed: {this.NumberOfEmployeesManaged}\t";
            return msg;
        }
    }
    public class Engineer : Employee
    {
        private string specialization = "n/a";

        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }
        public Engineer(string aName, int aSalary, string aSpecialization) : base(aName, aSalary)
        {
            this.specialization = aSpecialization;
        }
        public override string ToString()
        {
            string msg = "";
            msg += $"Name: {this.Name}\t";
            msg += $"\tSalary: {this.Salary}\t";
            msg += $"Specialization: {this.specialization}\t";
            return msg;
        }
    }



}
