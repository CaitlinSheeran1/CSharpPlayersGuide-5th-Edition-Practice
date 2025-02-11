// Caitlin Sheeran
// 1/31/2025


using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace VinFletchersArrows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrow userChoices = new Arrow();

            Console.WriteLine($"Arrow Type: {userChoices.ArrowHeadType = ArrowHeadChoice()}\n");
            Console.WriteLine($"Arrow Type: {userChoices.FletchingType = FletchingTypeChoice()}\n");
            Console.WriteLine($"Arrow Type: {userChoices.Length = LengthChoice()}\n");
            Console.WriteLine($"You owe: {userChoices.GetCost(userChoices.ArrowHeadType, userChoices.FletchingType, userChoices.Length)} pieces of golds");


            static ArrowType ArrowHeadChoice()
            {
                Console.WriteLine("Please choose Steel, Wood, or Obsidian: ");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "Steel": return ArrowType.Steel;
                    case "Wood": return ArrowType.Wood;
                    case "Obsidian": return ArrowType.Obsidian;
                    default: return ArrowType.None;

                }
            }
            static FletchingType FletchingTypeChoice()
            {
                Console.WriteLine("Please choose Plastic, Turkey Feathers, Goose Feathers: ");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "Plastic": return FletchingType.Plastic;
                    case "Turkey Feathers": return FletchingType.TurkeyFeathers;
                    case "Goose Feathers": return FletchingType.GooseFeathers;
                    default: return FletchingType.None;

                }
            }
        }
        static float LengthChoice()
        {
            Console.WriteLine("Please give a length between 60-100 cm: ");
            double answer = Convert.ToDouble(Console.ReadLine());
            float newAnswer = (float)answer;
            return newAnswer;
        }

    }



    public class Arrow
    {
        // changed these to private fields 
        private ArrowType arrowheadType = ArrowType.None;
        private FletchingType fletchingType = FletchingType.None;
        private float length = -1;

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

        public Arrow(ArrowType aArrowHeadType, FletchingType aFletchingType, float aLength)
        {
            this.ArrowHeadType = aArrowHeadType;
            this.FletchingType = aFletchingType;
            this.Length = aLength;

        }
        public Arrow() { }

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
    }

    public enum ArrowType { Steel, Wood, Obsidian, None }; // will deafult to private
    public enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers, None };
}