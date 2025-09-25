// Caitlin Sheeran
// 9/24/2025

namespace CharBerryTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CranberryTree tree = new CranberryTree();
            Notifier notifier = new Notifier(tree);
            Harvestor harvestor = new Harvestor(tree);

            while (true)
            {
                tree.MaybeGrow();
                
            }
        }
    }
    public class CranberryTree
    {
        private Random _random = new Random();

        public bool Ripe { get; set; }

        public event Action? Ripened; 

        public void MaybeGrow()
        {
            if (_random.NextDouble() < 0.00000001 && !Ripe) { Ripe = true; Ripened?.Invoke(); }
        }
    }
    public class Notifier
    {
        public Notifier(CranberryTree tree)
        {
            tree.Ripened += OnRipened;
        }
        public Notifier() { }
        private void OnRipened()
        {
            Console.WriteLine("A charberry fruit has fallen!");
        }
    }
    public class Harvestor
    {
        private CranberryTree _tree;
        public Harvestor(CranberryTree tree)
        {
            _tree = tree;
            tree.Ripened += OnRipened;
        }
        public Harvestor() { }
        private void OnRipened()
        {
            _tree.Ripe = false;
            Console.WriteLine("Fruit harvested!");
        }
    }

}
