
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace inventoryManagmentProgram2
{
    public class ReadInventoryData
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
                catch (Exception e)
                {
                    Console.WriteLine("problem in getting data {0}", e);
                    return null;
                }
            }
        }
    }
}
