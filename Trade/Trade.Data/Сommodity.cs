using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Trade.Data
{
    public class Commodity : Base
    {
        static public List<Commodity> Commodities = new List<Commodity>();

        private Guid _item_productID;

        public string Name { get; private set; }
        private double cost;



        public Commodity this[int index]
        {
            set
            {
                Commodities[index] = value;
            }
            get
            {
                return Commodities[index];
            }
        }

        public string Units { get; private set; }
        public string Brand { get; private set; }
        public string Count_of_cost { get; private set; }

        public double Cost
        {
            set
            {
                if (value < 0)
                {
                    cost = 0;
                }
                else
                {
                    cost = value;
                }
            }
            get
            {
                return cost;
            }
        }

        public Commodity(string name, double cost, string units, string brand)
        {
            Name = name;
            Cost = cost;
            Units = units;
            Brand = brand;
        }

        public Commodity()
        {  }

        private string _Cost(double Cost)
        {
            double cost_half = 0.5 * Cost;
            double cost_fourth = 0.25 * Cost;
            return "Cost for half: " + cost_half + "/" +
                    " Cost for forth: " + cost_fourth;
        }

        public List<СommodityInOrganization> CommodityInOrganizations
        {
            get
            {
                List<СommodityInOrganization> result = new List<СommodityInOrganization>();
                foreach (СommodityInOrganization cio in СommodityInOrganization.CommodityInOrganizations)
                    if (cio.Commodity == this)
                        result.Add(cio);
                return result;
            }
        }
        public List<Organization> Organizations
        {
            get
            {
                List<Organization> result = new List<Organization>();
                foreach (СommodityInOrganization cio in СommodityInOrganization.CommodityInOrganizations)
                    if (cio.Commodity == this)
                        result.Add(cio.Organization);
                return result;
            }
        }
        static public List<Commodity> _Commodities = new List<Commodity>();
       
        public Item_product Item_Product
        {
            get
            {
                foreach (Item_product item_product in Item_product.Item_products)
                    if (item_product.ID == _item_productID)
                        return item_product;
                return null;
            }
            set
            {
                _item_productID = value.ID;
            }
        }

        static public List<Commodity> __Commodities = new List<Commodity>();

        public Item_product Item_Products { get; }

        public override string  ToString()
        {
            return "Name: " + Name + "/" +
                   " Brand: " + Brand + "/" +
                   " Units : " + Units + "/" +
                   " Cost: " + Cost + "/"+ _Cost(Cost);
        }
    }
}
