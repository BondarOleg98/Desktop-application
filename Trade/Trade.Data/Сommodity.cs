using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace Trade.Data
{
    [DataContract]
    [KnownType(typeof(Industrial))]
    [KnownType(typeof(Products))]
    public class Commodity : Base, ISerialize
    {
        [DataMember]
        public static List<Commodity> Commodities = new List<Commodity>();

        public static List<Commodity> commod_cost = new List<Commodity>();
        public static List<Commodity> commodities = new List<Commodity>();
       

        private Guid _item_productID;

        private double cost;

        private static double mincost = 1;

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

        [DataMember]
        public static List<Commodity> _commodities = new List<Commodity>();

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Units { get; set; }

        [DataMember]
        public string Generator { get; set; }

        public string Count_of_cost { get; set; }

        [DataMember]
        public string Shelf_life { get; set; }

        [DataMember]
        public double Cost
        {
            set
            {
                if (value < 0)
                {
                    cost = mincost;
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

        public Item_product Item_Products { get; }

        public Commodity(string name, double cost, string units, string generator, string shelf_life)
        {
            Name = name;
            Cost = cost;
            Units = units;
            Generator = generator;
            Shelf_life = shelf_life;
        }

        public Commodity()
        { }

        public static List<Commodity> Commodity_Cost()
        {
          
            foreach(var commodities in Commodities)
            {
              
                if (commodities.Cost<=10)
                {
                    commod_cost.Add(commodities);
                }
              
            }
            return commod_cost;
        }

        ~Commodity()
        {
            DataContractSerializer dsc = new DataContractSerializer(typeof(List<Commodity>));
            XmlWriter xmlWriter = XmlWriter.Create("Commodities.xml");
            dsc.WriteObject(xmlWriter, Commodities);
            xmlWriter.Close();
        }

        public static string _Cost(double Cost)
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

        public virtual List<Commodity> Load(int flag)
        {
            if (flag == 1)
            {
                DataContractSerializer dsc = new DataContractSerializer(typeof(List<Commodity>));
                XmlReader xmlReader = XmlReader.Create("Industrial goods.xml");
                List<Commodity> result = (List<Commodity>)dsc.ReadObject(xmlReader);
                xmlReader.Close();
                return result;
            }
            else
            {
                DataContractSerializer dsc = new DataContractSerializer(typeof(List<Commodity>));
                XmlReader xmlReader = XmlReader.Create("Commodities.xml");
                List<Commodity> result = (List<Commodity>)dsc.ReadObject(xmlReader);
                xmlReader.Close();
                return result;
            }                    
        }

        public virtual void Save(int flag)
        {
            if(flag == 1)
            {
                DataContractSerializer dsc = new DataContractSerializer(typeof(List<Commodity>));
                XmlWriter xmlWriter = XmlWriter.Create("Industrial goods.xml");
                dsc.WriteObject(xmlWriter, _commodities);
                xmlWriter.Close();
            }
            else
            {
                DataContractSerializer dsc = new DataContractSerializer(typeof(List<Commodity>));
                XmlWriter xmlWriter = XmlWriter.Create("Commodities.xml");
                dsc.WriteObject(xmlWriter, Commodities);
                xmlWriter.Close();
            }              
        }

        public override string ToString()
        {
            return "Name: " + Name + "/" +
                   " Generator: " + Generator + "/" +
                   " Units : " + Units + "/" +
                   " Cost: " + Cost + "/"+ _Cost(Cost)+ "/" +
                   " Shelf life: " + Shelf_life;
        }
    }
}
