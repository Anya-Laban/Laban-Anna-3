//Створити програму, яка задовольняє наступним вимогам:
//• Використовувати можливості ООП: класи, наслідування, поліморфізм, інкапсуляція.
//• Кожен клас повинен мати змістовну назву та інформативний склад.
//• Наслідування має застосовуватися тільки тоді, коли це має сенс.
//• Класи повинні бути грамотно розкладені по пакетах.
//• Консольне меню повинно бути мінімальним.


//• Для зберігання параметрів ініціалізації можна використовувати файли.

//Мотоцикліст.
//Визначити ієрархію амуніції.
//Екіпірувати мотоцикліста.
//Підрахувати вартість.
//Провести сортування амуніції на основі ваги.
//Знайти елементи амуніції, відповідні заданому діапазону параметрів ціни.
using System.Text.Json;
using ConsoleApp3._2;
internal class Program
{
    static void Main(string[] args)
    {
        string st; int number; List <Amunition> amunitions = new List <Amunition>() { new Boots(), new Gloves(), new Helmet(), new Jacket(), new Pants()};
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Motorcyclist motorcyclist = new Motorcyclist(name);
       
        bool isWorking = true;
        while (isWorking)
        {
            Console.Clear();
            ShowAllGoods(amunitions);
            while (true)
            {

                st = Console.ReadLine();

                if (int.TryParse(st, out number) && number >= 1 && number < amunitions.Count + 1)
                {
                    break;
                }
            }
            amunitions[number - 1].ShowInfo();
            Console.WriteLine("\nIf you want to buy this product, enter 1.\nIf you want to see other products, enter 2.\nIf you want exit to shop, enter something else.");

            switch (Console.ReadLine())
            {
                case "1":
                    motorcyclist.AddAmunition(amunitions[number - 1]);
                    break;
                case "2":
                    break;
                default:
                    isWorking = false;
                    break;
            }
        }
        isWorking = true;
        while (isWorking)
        {
            Console.Clear();
            Console.WriteLine("\nEnter 1, if you want to see all price for your amunitions.\nEnter 2, if you want to see elements in some price diapasone.\nEnter 3, if you want to see sorted amunition.");
            switch (Console.ReadLine())
            {
                case "1":
                    motorcyclist.PriceAllAmunition();
                    break;
                case "2":
                    Console.Write("Enter start of diapasone:");
                    int minValue = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter end of diapasone:");
                    int maxValue = Convert.ToInt32(Console.ReadLine());
                    if (minValue > maxValue)
                    {
                        int c = minValue;
                        minValue = maxValue;
                        maxValue = c;
                    }
                    motorcyclist.ElementsInPriceDiapasone(minValue, maxValue);
                    break;
                case "3":
                    motorcyclist.SortAmunition();
                    break;
                default:
                    Safe(motorcyclist);
                    isWorking = false;
                    break;
            }
        }
        Console.ReadKey();
    }
    public static void ShowAllGoods(List<Amunition> amunitions)
    {
        Console.WriteLine("Here is the full range of goods,to see more detailed information about a particular product,\nenter the number of this product : ");
        for (int i = 0; i < amunitions.Count; i++)
        {
            Console.WriteLine(i + 1 + " - " + amunitions[i].Name);
        }
    }
    public static void Safe(Motorcyclist motorcyclist)
    {
        const string _pathToFileJson = "C:\\Users\\Anna\\Desktop\\js.txt";
        using (FileStream fs = new FileStream(_pathToFileJson, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(fs, motorcyclist);
        }
        Console.WriteLine($"Збережено у файл json.");
    }
}







