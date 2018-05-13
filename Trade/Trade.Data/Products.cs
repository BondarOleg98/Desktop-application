using System.Collections.Generic;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.IO;

namespace Trade.Data
{
    [DataContract]
    [KnownType(typeof(MilkProducts))]
    [KnownType(typeof(FishProducts))]
    public class Products : Commodity
    {
        [DataMember]
        static public List<Products> Product_milk = new List<Products>();

        [DataMember]
        static public List<Products> Product_fish = new List<Products>();

        [DataMember]
        public string Thread { get; set; }

        [DataMember]
        public string Package { get; set; }

        public Products(string thread, string package, string name, double cost, string units, string generator, string shelf_life)
            : base(name, cost, units, generator, shelf_life)
        {
            Thread = thread;
            Package = package;
        }
        public Products()
        { }

        public static List<Products> Load_product(int flag)
        {
            if (flag == 1)
            {
                DataContractSerializer dsc = new DataContractSerializer(typeof(List<Products>));
                XmlReader xmlReader = XmlReader.Create("Milk_goods.xml");
                List<Products> result = (List<Products>)dsc.ReadObject(xmlReader);
                xmlReader.Close();
                return result;
            }
            else
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Products>));
                FileStream jsonWrite = File.OpenRead("Fish_goods.json");
                List<Products> result = (List<Products>)jsonSerializer.ReadObject(jsonWrite);
                
                jsonWrite.Close();
                return result;

            }
        }

        public override void Save(int flag)
        {
            if (flag == 1)
            {
                DataContractSerializer dsc= new DataContractSerializer(typeof(List<Products>));
                XmlWriter xmlWriter = XmlWriter.Create("Milk_goods.xml");
                dsc.WriteObject(xmlWriter, Product_milk);
                xmlWriter.Close();
            }
            else if (flag == 2)
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Products>));
                FileStream jsonWrite = File.Create("Fish_goods.json");
                jsonSerializer.WriteObject(jsonWrite, Product_fish);
                jsonWrite.Close();
            }
        }
    }
}
