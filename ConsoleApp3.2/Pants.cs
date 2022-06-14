
namespace ConsoleApp3._2
{
    class Pants : Amunition
    {
        public override string Name { get; protected set; } = "Pants";
        public override double Weight { get; protected set; } = 0.31;
        public override double Price { get; protected set; } = 280;
        public override string Size { get; protected set; } = "L";
        public string Material { get; private set; } = "Textile";
        public bool Kneeprotection { get; private set; } = true;
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Kneeprotection: " + Kneeprotection);
        }

    }
}
