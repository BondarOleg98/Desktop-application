using System;
using System.Runtime.Serialization;
using System.Xml;

namespace Trade.Data
{
    [DataContract]
    public class MilkProducts : Products
    {
        [DataMember]
        public double Fat_content { get; set; }

        [DataMember]
        public string Milk_products { get; set; }

        [DataMember]
        public string Type_milk_product { get; set; }

        public MilkProducts(double fat_content, string milk_product, string type_milk_product,
            string thread, string package, string name, double cost, string units, string generator, string shelf_life)
            :base(thread, package, name, cost, units, generator, shelf_life)
        {
            Fat_content = fat_content;
            Milk_products = milk_product;
            Type_milk_product = type_milk_product;
        }

        public override string ToString()
        {
            return "Name: " + Name + "/" +
                   "Thread: " + Thread + "/" +
                   "Package: " + Package + "/" +
                   "Fat_content: " + Fat_content +"/"+
                   "Product: " + Milk_products +"/" +
                   "Type_milk_product: "+ Type_milk_product;
        }
    }
}
