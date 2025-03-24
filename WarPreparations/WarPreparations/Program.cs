// Caitlin Sheeran
// 2/25/2025

using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

namespace WarPreparations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword sword1 = new Sword(SwordMaterials.Iron, Gemstones.None, 12, 4);
            Sword sword2 = sword1 with {Material =  SwordMaterials.Wood, Gemstone = Gemstones.Emerald, Length = 10, Crossguard = 2 };
            Sword sword3 = sword1 with { Material = SwordMaterials.RareBinarium, Gemstone = Gemstones.RareBitstone, Length = 3, Crossguard = 4 };
            Console.WriteLine(sword1);
            Console.WriteLine(sword2);
            Console.WriteLine(sword3);

        }
    }
    public record Sword(SwordMaterials Material, Gemstones Gemstone, int Length, int Crossguard) { }



    public enum SwordMaterials{None, Wood, Bronze, Iron, Steel, RareBinarium};
    public enum Gemstones { None, Emerald, Amber, Sapphire, Diamond, RareBitstone };
}
