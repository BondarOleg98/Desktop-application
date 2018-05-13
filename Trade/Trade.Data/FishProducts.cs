using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;

namespace Trade.Data
{
    [DataContract]
    public class FishProducts : Products
    {      
        [DataMember]
        public string Goods_canned { get; set; }

        [DataMember]
        public string Type_fish { get; set; }
    
        public FishProducts(string goods_canned, string type_fish, string thread, string package, string name, double cost, string units, string generator, string shelf_life)
            :base(thread, package, name, cost, units, generator, shelf_life)
        {
            Goods_canned = goods_canned;
            Type_fish = type_fish;
        }

        public override string ToString()
        {
            return "Name: " + Name + "/" +
                   "Thread: " + Thread + "/" +
                   "Package: " + Package + "/" +
                   "Goods_canned: " + Goods_canned + "/"+
                   "Type_fish: " + Type_fish;
        }
    }
}
