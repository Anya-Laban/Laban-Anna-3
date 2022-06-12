
namespace ConsoleApp3._2
{
    class Helmet : Amunition
    {
        public override string Name { get; protected set; } = "Helmet";
        public override double Weight { get; protected set; } = 1.30;
        public override double Price { get; protected set; } = 300;
        public override string Size { get; protected set; } = "L";
        private bool Glass = false;
        public string Color { get; private set; } = "Black";

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Glass: " + Glass);
            Console.WriteLine("Color" + Color);
        }
    }
}
