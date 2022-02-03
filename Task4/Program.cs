using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store oceanMall = new Store(3);
            oceanMall[0] = new Article { Name = "Sneakers", StoreName = "Nike", PriceUAH = 2500 };
            oceanMall[1] = new Article { Name = "IPhone", StoreName = "Apple", PriceUAH = 10000 };
            oceanMall[2] = new Article { Name = "Cup", StoreName = "ProKitchen", PriceUAH = 200 };

            Console.WriteLine(oceanMall[0]);
            Console.WriteLine(oceanMall["Cup"]);
            Console.WriteLine(oceanMall["Coat"]);

        }
    }
}
