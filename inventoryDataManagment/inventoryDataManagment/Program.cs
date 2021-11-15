using System;

namespace inventoryDataManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = "C:/Users/AKASH/json/Inventory.json";
            Console.WriteLine("welcom to the inventory data management!!");

            ReadInventoryData obj = new ReadInventoryData();
            InventoryManagmentModel data = obj.Read(Path);

            for (int i=0;i<data.Rise.Count;i++)
            {
                Console.WriteLine("Rice details");
                Console.WriteLine("Name: " + data.Rise[i].name + "weight: "+ data.Rise[i].weight+ "price: " + data.Rise[i].price);
            }
            for (int i = 0; i < data.Pulses.Count; i++)
            {
                Console.WriteLine("Pulses details");
                Console.WriteLine("Name: " + data.Pulses[i].name + "weight: " + data.Pulses[i].weight + "price: " + data.Pulses[i].price);
            }
            for (int i = 0; i < data.Wheat.Count; i++)
            {
                Console.WriteLine("wheat details");
                Console.WriteLine("Name: " + data.Wheat[i].name + "weight: " + data.Wheat[i].weight + "price: " + data.Wheat[i].price);
            }
        }
    }
}
