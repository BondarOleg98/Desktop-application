using System.Runtime.Serialization;

namespace Trade.Data
{
    [DataContract]
    public class Industrial : Commodity
    {       
        [DataMember]
        public string Size { get; set; }

        [DataMember]
        public string Material { get; set; }

        [DataMember]
        public string Color { get; set; }

        public Industrial(string size, string material, string color,
            string name, double cost, string units, string generator, string shelf_life)
            :base(name, cost, units, generator, shelf_life)
        {
            Size = size;
            Material = material;
            Color = color;
        }

        public override string ToString()
        {
            return  "Name: " +Name+ "/"+ "Size: " + Size+"/" +
                    "Material: " + Material + "/" +
                    "Color: " + Color;
        }
    }
}
