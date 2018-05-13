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
       
        public string Name {get; set; }
        public string serial_number;
        public string Serial_number
        {
            set
            {
                serial_number = value;
            }
        }

        public Guid _commodityID;
        string Short_name { get; }

        public Item_product(string name, string serial_number)
        {
            Name = name;
            Serial_number = serial_number;
            Short_name = Short_Name(Name);
        }

        public static string Short_Name(string Name)
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

        public Item_product()
        {

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
