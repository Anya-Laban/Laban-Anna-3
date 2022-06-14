
namespace ConsoleApp3._2
{
    class Jacket : Amunition
    {
        public override string Name { get; protected set; } = "Jacket";
        public override double Weight { get; protected set; } = 0.40;
        public override double Price { get; protected set; } = 500;
        public override string Size { get; protected set; } = "XL";
        public string Material { get; private set; } = "Leather";
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Material: " + Material);
        }
    }
}
