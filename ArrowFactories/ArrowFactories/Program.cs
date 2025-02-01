// Caitlin Sheeran
// 1/31/2025


using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace VinFletchersArrows
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Asks user if they want a pre-built arrow or a custom one
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------");
            Console.Write("Would you like to buy a prebuilt arrow? (Y/N): ");
            string userChoice = Console.ReadLine().ToUpper();


            // if user wants a pre-built it will give them three options
            if (userChoice == "Y")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1:\tElite Arrow: Steel Arrowhead, Plastic Fletching, and 95 cm Shaft");
                Console.WriteLine("2:\tBeginner Arrow: Wood Arrowhead, Goose Feathers, and 75 cm Shaft");
                Console.WriteLine("3:\tMarksman Arrow: Steel Arrowhead, Goose Feathers, and 65 cm Shaft\n");

                Console.Write("Please select 1, 2, or 3: ");
                string userArrowChoice = Console.ReadLine();

                // creates a new arrow that will call for a default
                Arrow selectedArrow = new Arrow(ArrowType.None, FletchingType.None, 0);

                if (userArrowChoice == "1") selectedArrow = Arrow.CreateEliteArrow();
                else if (userArrowChoice == "2") selectedArrow = Arrow.CreateBeginnerArrow();
                else if (userArrowChoice == "3") selectedArrow = Arrow.CreateMarksmanArrow();

                // Displays the amount the user owes
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine($"You owe {selectedArrow.GetCost(selectedArrow.ArrowHeadType, selectedArrow.FletchingType, selectedArrow.Length)} pieces of gold");
                Console.WriteLine("----------------------------------");

            }
            else
            {
                // creates an arrow that the user will updata with parameters
                Arrow userChoices = new Arrow();


                // Tells user what they selected while calling the methods 
                Console.WriteLine($"Arrow Type: {userChoices.ArrowHeadType = ArrowHeadChoice()}\n");
                Console.WriteLine($"Arrow Type: {userChoices.FletchingType = FletchingTypeChoice()}\n");
                Console.WriteLine($"Arrow Type: {userChoices.Length = LengthChoice()}\n");

                //Displays ammount user owes
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine($"You owe: {userChoices.GetCost(userChoices.ArrowHeadType, userChoices.FletchingType, userChoices.Length)} pieces of golds");
                Console.WriteLine("----------------------------------");


                // asks user for an arrowhead type
                static ArrowType ArrowHeadChoice()
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please choose Steel, Wood, or Obsidian: ");
                    string answer = Console.ReadLine();
                    Console.WriteLine();

                    switch (answer)
                    {
                        case "Steel": return ArrowType.Steel;
                        case "Wood": return ArrowType.Wood;
                        case "Obsidian": return ArrowType.Obsidian;
                        default: return ArrowType.None;

                    }
                }

                // asks user for a fletching type
                static FletchingType FletchingTypeChoice()
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please choose Plastic, Turkey Feathers, Goose Feathers: ");
                    string answer = Console.ReadLine();
                    Console.WriteLine();

                    switch (answer)
                    {
                        case "Plastic": return FletchingType.Plastic;
                        case "Turkey Feathers": return FletchingType.TurkeyFeathers;
                        case "Goose Feathers": return FletchingType.GooseFeathers;
                        default: return FletchingType.None;

                    }
                }
            }

            // asks user for a length
            static float LengthChoice()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please give a length between 60-100 cm: ");
                double answer = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                float newAnswer = (float)answer;
                return newAnswer;
            }

            Console.ReadKey();
        }





            

    }



    public class Arrow
    {
        // class fields
        private ArrowType arrowheadType = ArrowType.None;
        private FletchingType fletchingType = FletchingType.None;
        private float length = -1;

        
        // gets and sets
        public ArrowType ArrowHeadType
        {
            get { return this.arrowheadType; }
            set { this.arrowheadType = value; }
        }
        public FletchingType FletchingType
        {
            get { return this.fletchingType; }
            set { this.fletchingType = value; }
        }
        public float Length
        {
            get { return this.length; }
            set
            {
                if (length >= 60 && length <= 100) this.length = value;
            }
        }

        // full constructor
        public Arrow(ArrowType aArrowHeadType, FletchingType aFletchingType, float aLength)
        {
            this.ArrowHeadType = aArrowHeadType;
            this.FletchingType = aFletchingType;
            this.Length = aLength;

        }

        // empty constructor
        public Arrow() { }


        // calcualtes the cost of the arrow and returns the total
        public float GetCost(ArrowType ArrowHeadType, FletchingType FletchingType, float Length)
        {

            float total = Length * 0.05f;

            if (ArrowHeadType == ArrowType.Steel) total += 10.0f;
            else if (ArrowHeadType == ArrowType.Wood) total += 3.0f;
            else total += 5.0f;

            if (FletchingType == FletchingType.Plastic) total += 10.0f;
            else if (FletchingType == FletchingType.TurkeyFeathers) total += 5.0f;
            else total += 3.0f;

            return total;

        }

        // Pre-defined arrows user can choose if they don't want to make their own 
        public static Arrow CreateEliteArrow()
        {
            return new Arrow(ArrowType.Steel, FletchingType.Plastic, 95.0f);
        }
        public static Arrow CreateBeginnerArrow()
        {
            return new Arrow(ArrowType.Wood, FletchingType.GooseFeathers, 75.0f);
        }
        public static Arrow CreateMarksmanArrow()
        {
            return new Arrow(ArrowType.Steel, FletchingType.GooseFeathers, 65.0f);
        }
    }

    public enum ArrowType { Steel, Wood, Obsidian, None }; // will deafult to private
    public enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers, None };
}