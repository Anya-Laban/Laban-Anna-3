
namespace ConsoleApp3._2
{
    class Motorcyclist
    {
        public string Name { get; private set; }
        private List<Amunition> _amunitions = new List<Amunition>();
        public List<Amunition> Amunitions 
        { 
            get { return _amunitions; }
            private set { _amunitions = value; }
        }
        public double MoneyForAmmunition { get; private set; }
        public Motorcyclist(string name)=> Name = name;
        public void AddAmunition(Amunition amunition)
        {
            bool t = false;
            for (int i = 0; i < _amunitions.Count; i++)
            {
                if (amunition.Equals(_amunitions[i]) == true)
                {
                    _amunitions[i].CountOfGoods++;
                    //MoneyForAmmunition += _amunitions[i].Price;
                    t = true;
                }
            }
             if(t==false)
             {
                _amunitions.Add(amunition);
                Amunition am = _amunitions.Last();
                //MoneyForAmmunition += am.Price;
                am.CountOfGoods++;
             }

        }
        public void PriceAllAmunition()
        {
            for (int i = 0; i < _amunitions.Count; i++)
            {
                MoneyForAmmunition += _amunitions[i].Price * _amunitions[i].CountOfGoods;
            }
            Console.WriteLine(MoneyForAmmunition);
            Console.ReadKey();
        }
        public void SortAmunition()
        {
            var sortedAmunition = _amunitions.OrderBy(x => x.Weight).ToList();

            for (int i = 0; i < sortedAmunition.Count; i++)
            {
                Console.Write(i + 1 + ") ");
                sortedAmunition[i].ShowInfo();
            }
            Console.ReadKey();
        }
        public void ElementsInPriceDiapasone(double a, double b)
        {
            var ElementsInPriceDiapasone1 = _amunitions.Where(x => x.Price >= a && x.Price <= b).OrderBy(x => x.Price).ToList();
            for (int i = 0; i < ElementsInPriceDiapasone1.Count; i++)
            {
                Console.WriteLine(i + 1 + ")");
                ElementsInPriceDiapasone1[i].ShowInfo();

            }
            Console.ReadKey();
        }
        
    }
}
