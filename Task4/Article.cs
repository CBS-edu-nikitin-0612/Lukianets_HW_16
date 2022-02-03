using System;

namespace Task4
{
    internal class Article
    {
        private string _name;
        private string _storeName;
        private double _priceUAH;

        public string Name
        {
            get => _name;
            set
            {
                if (value != null)
                    _name = value;
                else
                    Console.WriteLine("Wrong input");
            }
        }

        public string StoreName
        {
            get => _storeName;
            set
            {
                if (value != null)
                    _storeName = value;
                else
                    Console.WriteLine("Wrong input");
            }
        }

        public double PriceUAH
        {
            get => _priceUAH;
            set
            {
                if (value > 0)
                    _priceUAH = value;
                else
                    Console.WriteLine("Wrong input");
            }
        }

        public override string ToString()
        {
            return $"{Name} is sold in {StoreName}, price - {PriceUAH} UAH";
        }
    }
}
