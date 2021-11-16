using System;

namespace Stockes
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = "C:/Users/AKASH/json/stocks.json";
            Console.WriteLine("welcom to the Stocks price!!");

            readStocksData obj = new readStocksData();
            stockesName data = obj.Read(Path);

            for(int i = 0; i < data.amazon.Count; i++)
            {
                int totalStocksPrice = data.amazon[i].price * data.amazon[i].numberOfStockes;

                Console.WriteLine("Amazon's stocks " + data.amazon[i].type + " price is : " + totalStocksPrice);
            }
            for (int i = 0; i < data.tesla.Count; i++)
            {
                int totalStocksPrice = data.tesla[i].price * data.tesla[i].numberOfStockes;

                Console.WriteLine("Tesla's stocks " + data.tesla[i].type + " price is : " + totalStocksPrice);
            }
            for (int i = 0; i < data.google.Count; i++)
            {
                int totalStocksPrice = data.google[i].price * data.google[i].numberOfStockes;

                Console.WriteLine("Google's stocks " + data.google[i].type + " price is : " + totalStocksPrice);
            }

        }
    }
}
