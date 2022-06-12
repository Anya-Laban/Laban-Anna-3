using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._2
{
    abstract class Amunition
    {

        public abstract string Name { get; protected set; }
        public abstract double Weight { get; protected set; }
        public abstract double Price { get; protected set; }
        public abstract string Size { get; protected set; }
        public int CountOfGoods { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name}: ");
            Console.WriteLine("Count you have: " + CountOfGoods);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Size: " + Size);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Amunition amunition = obj as Amunition;
            if (amunition == null) return false;
            return amunition.Name == Name;
        }
    }
}
