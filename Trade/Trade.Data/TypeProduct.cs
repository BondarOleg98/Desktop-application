using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data
{
    public class TypeProduct : Commodity
    {
        static public List<TypeProduct> typeproduct = new List<TypeProduct>();

        public string Name_typeproduct { get; private set; }

        public TypeProduct(string name_typeproduct, string name, double cost, string units, string brand)
            :base(name, cost, units, brand)
        {
            Name_typeproduct = name_typeproduct;
        }

        public override string ToString()
        {
            return Name_typeproduct;
        }
    }
}
