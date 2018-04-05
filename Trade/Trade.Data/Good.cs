using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data
{
    public class Good
    {
        static public List<Good> Goods = new List<Good>();

        public string Name { get; private set; }
        public double Cost { get; private set; }

        public Good(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }


    }
}
