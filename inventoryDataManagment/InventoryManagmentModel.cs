using System;
using System.Collections.Generic;
using System.Text;

namespace inventoryDataManagment
{
    class InventoryManagmentModel
    {
        public List<Rise>Rise;
        public List<Pulses>Pulses;
        public List<Wheat>Wheat;

    }
    public class Rise
    {
        public string name;
        public string weight;
        public int price;
    }
    public class Pulses
    {
        public string name;
        public string weight;
        public int price;
    }
    public class Wheat
    {
        public string name;
        public string weight;
        public int price;
    }
}
