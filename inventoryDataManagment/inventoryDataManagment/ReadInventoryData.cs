using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace inventoryDataManagment
{
    class ReadInventoryData
    {
        internal InventoryManagmentModel Read(string Path)
        {

            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    String json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryManagmentModel>(json);

                }
                catch(Exception e)
                {
                    Console.WriteLine("problem in getting data {0}", e);
                    return null;
                }
            }
        }

    }
}
