// Caitlin Sheeran
// 2/18/2025

namespace RoomCoordinates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordinate cord = new Coordinate();
            Console.WriteLine(cord.Adjacent(1, 2, 2, 3));
            Console.WriteLine(cord.Adjacent(1, 2, 6, 3));
            Console.WriteLine(cord.Adjacent(4, 4, 8, 7));
        }
    }
    public struct Coordinate
    {
        public int row1;
        public int col1;
        public int row2;
        public int col2;

        public int Row1 { get { return row1; } }
        public int Col1 { get { return col1; } }
        public int Row2 { get { return row2; } }
        public int Col2 { get { return col2; } }

        public Coordinate(int aRow1, int aCol1, int aRow2, int aCol2)
        {
            this.row1 = aRow1;
            this.col1 = aCol1;
            this.row2 = aRow2;
            this.col2 = aCol2;
        }
        public bool Adjacent(int row1, int col1,int row2, int col2)
        {
            if (((row1 + 1 == row2) || (row1 - 1 == row2)) && ((col1 + 1 == col2) || (col1 - 1 == col2)))
            {
                return true;
            }
            else return false;
        }


    }
}
