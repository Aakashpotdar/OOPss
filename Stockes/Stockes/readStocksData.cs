using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stockes
{
    class readStocksData
    {
        internal stockesName Read(string Path)
        {
            using(StreamReader file=new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<stockesName>(json);
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
