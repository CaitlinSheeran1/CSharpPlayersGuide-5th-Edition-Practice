// Caitlin Sheeran
// 2/18/2025

using System;

namespace PackingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack(10, 20, 30);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(pack);
                Console.WriteLine($"Pack is currently at {pack.totalItems}/{pack.Items.Length} items, {pack.currentWeight}/{pack.MaxWeight} weight, and {pack.currentVolume}/{pack.MaxVolume} volume.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--------------------------------------------------------------------");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What do you want to add?");
                Console.WriteLine("1 - Arrow");
                Console.WriteLine("2 - Bow");
                Console.WriteLine("3 - Rope");
                Console.WriteLine("4 - Water");
                Console.WriteLine("5 - Food");
                Console.WriteLine("6 - Sword");
                int choice = Convert.ToInt32(Console.ReadLine());

                InventoryItem newItem = choice switch
                {
                    1 => new Arrow(),
                    2 => new Bow(),
                    3 => new Rope(),
                    4 => new Water(),
                    5 => new Food(),
                    6 => new Sword(),
                    _ => null
                };

                if (newItem != null && !pack.Add(newItem))
                    Console.WriteLine("Could not add this to the pack.");
            }
        }

        public class Pack
        {
            private InventoryItem?[] items = [];
            private double maxWeight;
            private double maxVolume;
            public int totalItems = 0;
            public double currentWeight = 0;
            public double currentVolume = 0;

            public InventoryItem?[] Items
            {
                get { return this.items; }
            }
            public double MaxWeight
            {
                get { return this.maxWeight; }
            }
            public double MaxVolume
            {
                get { return this.maxVolume; }
            }


            public Pack(int aMaxItems, double aMaxWeight, double aMaxVolume)
            {
                this.items = new InventoryItem[aMaxItems];
                this.maxWeight = aMaxWeight;
                this.maxVolume = aMaxVolume;

            }

            public bool Add(InventoryItem item)
            {
                if (totalItems >= items.Length) return false;
                if (currentWeight + item.Weight >= MaxWeight) return false;
                if (currentVolume + item.Volume >= MaxVolume) return false;


                Items[totalItems] = item;
                totalItems++;
                currentVolume += item.Volume;
                currentWeight += item.Weight;
                return true;
            }
            public override string ToString()
            {
                string packContains = "Pack containing ";
                if (totalItems == 0) packContains += "nothing";

                for (int i = 0; i < totalItems; i++) packContains += Items[i] + " ";
                return packContains;
            }


        }

        public class InventoryItem
        {
            public double weight;
            public double volume;

            public double Weight
            {
                get { return this.weight; }
                set { value = this.weight; }
            }
            public double Volume
            {
                get { return this.volume; }
                set { value = this.volume; }
            }


            public InventoryItem(double Weight, double Volume)
            {
                this.weight = Weight;
                this.volume = Volume;
            }



        }
        public class Arrow : InventoryItem { public Arrow() : base(0.1, 0.05) { } public override string ToString() { return "Arrow"; } }
        public class Bow : InventoryItem { public Bow() : base(1.0, 4.0) { } public override string ToString() { return "Bow"; } }
        public class Rope : InventoryItem { public Rope() : base(1.0, 1.5) { } public override string ToString() { return "Rope"; } }
        public class Water : InventoryItem { public Water() : base(2, 3) { } public override string ToString() { return "Water"; } }
        public class Food : InventoryItem { public Food() : base(1, 0.5) { } public override string ToString() { return "Food"; } }
        public class Sword : InventoryItem { public Sword() : base(5.0, 3.0) { } public override string ToString() { return "Sword"; } }

    }
}
