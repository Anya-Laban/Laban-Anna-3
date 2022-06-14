
namespace ConsoleApp3._2
{
    class Boots : Amunition
    {
        public override string Name { get; protected set; } = "Boots";
        public override double Weight { get; protected set; } = 1.30;
        public override double Price { get; protected set; } = 305;
        public override string Size { get; protected set; } = "43-43.5";
        public string Firm { get; private set; } = "Top";
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Firm: " + Firm);
        }

    }
}
