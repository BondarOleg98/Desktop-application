using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data
{
    public class Item_product : Base
    {
        static public List<Item_product> Item_products = new List<Item_product>();
       
        public string Name {get; private set; }
        public string serial_number;
        public string Serial_number
        {
            set
            {
                serial_number = value;
            }
        }

        private Guid _commodityID;
        readonly string Short_name;

        public Item_product(string name, string serial_number)
        {
            Name = name;
            Serial_number = serial_number;
            Short_name = Short_Name(Name);
        }

        static private string Short_Name(string Name)
        {
            string result;
            int num;
            num = Name.Length;
            if (num <= 3)
            {
                return Name;
            }
            else
            {
                result = (Name.Substring(0, 3));
                return result;
            }
        }

        public List<Commodity> Commodities
        {
            get
            {
                List<Commodity> result = new List<Commodity>();
                foreach (Commodity cip in Commodity.Commodities)
                    if (cip.Item_Product == this)
                        result.Add(cip);
                return result;
            }
        }
        public Commodity Commodity
        {
            get
            {
                foreach (Commodity commodity in Commodity.Commodities)
                    if (commodity.ID == _commodityID)
                        return commodity;
                return null;
            }
            set
            {
                _commodityID = value.ID;
            }
        }

        static public List<Item_product> _Item_products = new List<Item_product>();

        public override string ToString()
        {
            return "Name: " + Name +"/" + 
                   " Serial of number: " + serial_number + "/" +
                   " Short name: "+ Short_name;
        }

    }
}
