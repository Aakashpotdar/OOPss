using System;
using System.Collections.Generic;
using System.Text;

namespace Stockes
{
    public class stockesName
    {
        public List<Amazon> amazon;
        public List<Tesla> tesla;
        public List<Google> google;
    }
    public class Amazon
    {
        public string type;
        public int price;
        public int numberOfStockes;
    }
    public class Tesla
    {
        public string type;
        public int price;
        public int numberOfStockes;
    }
    public class Google
    {
        public string type;
        public int price;
        public int numberOfStockes;
    }
}
