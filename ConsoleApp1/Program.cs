//Створити додаток, який задовольняє вимогам, наведеним в завданні. Наслідування застосовувати тільки в тих завданнях, в яких воно логічно обґрунтоване.
//Аргументувати належність класу кожного створюваного методу і коректно перевизначити для кожного класу методи Equals, GetHashCode, ToString.
//При виклику будь-которого методу класу, виводити на екран текстове повідомлення.

//Створт класу Хижак, ви=111/'[уючи класи Кігті, Зуби. Методи: гарчати, бігти, спати, добувати їжу.


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var predator = new Predator("Volf");
            var predator2=new Predator("Lion");

            Console.WriteLine(predator.ToString());
            Console.WriteLine(predator.Equals(predator2));
            Console.WriteLine(predator.GetHashCode());

            predator.Run();
            predator.Sleep();
            Predator.Teeth.Growl(predator);
            Predator.Claws.GetFood(predator);
            Console.ReadKey();
        }
    }
    public class Predator
    {
        public  string Name { get; init; }
        public Predator(string name) => Name = name;
        public override string ToString()
        {
            return $"Хижак: {Name}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Predator predator = obj as Predator;
            if (predator == null) return false;
            return Name == predator.Name;
        }
        public override int GetHashCode() 
        {
            return Name.GetHashCode();
        }
        public void Run()
        {
            Console.WriteLine($"{Name} is running");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }

        public class Claws
        {
            public static void GetFood(Predator predator)
            {
                Console.WriteLine($"{predator.Name} gets food ");
            }
        }
        public class Teeth
        {
            public static void Growl(Predator predator)//гарчати
            {
                Console.WriteLine($"{predator.Name} growls");
            }
        }
    }



}

