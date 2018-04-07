using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data
{
    public class Products : TypeProduct
    {
        static public List<Products> products = new List<Products>();

        public string Name_product { get; private set; }

        public Products(string name_product, string name_typeproduct, string name, double cost, string units, string brand)
            : base(name_typeproduct, name, cost, units, brand)
        {
            Name_product = name_product;
        }

        public override string ToString()
        {
            return Name_product;
        }
    }
}
