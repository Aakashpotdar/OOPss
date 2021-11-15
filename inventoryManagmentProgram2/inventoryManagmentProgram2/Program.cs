using System;

namespace inventoryManagmentProgram2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Path = "C:/Users/AKASH/json/Inventory.json";
            Console.WriteLine("welcom to the inventory data management!!");

            ReadInventoryData obj = new ReadInventoryData();
            InventoryManagmentModel data = obj.Read(Path);

            for (int i = 0; i < data.Rise.Count; i++)
            {
                int RiseVlue = data.Rise[i].price * data.Rise[i].weight;
                Console.WriteLine("Rice details");
                Console.WriteLine("the value of " + data.Rise[i].name+" "+ RiseVlue);
            }
            for (int i = 0; i < data.Pulses.Count; i++)
            {
                int PulsesVlue = data.Pulses[i].price * data.Pulses[i].weight;
                Console.WriteLine("Pulses details");
                Console.WriteLine("the value of " + data.Pulses[i].name+" "+ PulsesVlue);
            }
            for (int i = 0; i < data.Wheat.Count; i++)
            {
                int WheatVlue = data.Wheat[i].price * data.Wheat[i].weight;
                Console.WriteLine("wheat details");
                Console.WriteLine("the value of " + data.Rise[i].name+" "+ WheatVlue);
            }

        }
    }
}
