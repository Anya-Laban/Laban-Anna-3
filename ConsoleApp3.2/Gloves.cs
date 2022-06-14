
namespace ConsoleApp3._2
{
    class Gloves : Amunition
    {
        public override string Name { get; protected set; } = "Gloves";
        public override double Weight { get; protected set; } = 0.15;
        public override double Price { get; protected set; } = 70.5;
        public override string Size { get; protected set; } = "XL";
        public string Ventilation { get; private set; } = "Insert for ventilation";
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Ventilation: " + Ventilation);
        }

    }
}
