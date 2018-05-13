using System;
using Trade.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.IO;

namespace Trade.Data
{
    [Serializable]
    [DataContract]
    public class Organization : Base, ISerializable
    {
        [DataMember]
        static public Dictionary<Guid, Organization> Organizations = new Dictionary<Guid, Organization>();
        
        private int data_creation;

        private static int last_year = 2200;

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Bank_account { get; set; }

        [DataMember]
        public string Head { get; set; }

        [DataMember]
        public int Data_creation
        {
            
            set
            {
                if ((value < 0)||(value>last_year))
                {
                    data_creation = 0;
                }
                else
                {
                    data_creation = value;
                }
            }
            get
            {
                return data_creation;
            }
        }

        private Guid _accountingID;

        public Organization(string name_org, int data_creation, string bank_account, string head)
        {
            Name = name_org; 
            Data_creation = data_creation;
            Bank_account = bank_account;
            Head = head;

        }

        public Organization() { }

        public static string Exist_organization(int data_creation)
        {
            int year = DateTime.Now.Year - data_creation;
            if((year<=0)||(year>last_year))
            {
                year = 0;
                return " Existed for " + year;
            }
            else 
            {
                return " Existed for " + year;
            }
            
        }

        public List<СommodityInOrganization> CommodityInOrganization
        {
            get
            {
                List<СommodityInOrganization> result = new List<СommodityInOrganization>();
                foreach (СommodityInOrganization cio in СommodityInOrganization.CommodityInOrganizations)
                    if (cio.Organization == this)
                        result.Add(cio);
                return result;
            }
        }

        public List<Commodity> Commodities
        {
            get
            {
                List<Commodity> result = new List<Commodity>();
                foreach (СommodityInOrganization cio in СommodityInOrganization.CommodityInOrganizations)
                    if (cio.Organization == this)
                        result.Add(cio.Commodity);
                return result;
            }
        }

        public Accounting Accounting
        {
            get
            {
                return Accounting.Accountings[_accountingID];
            }
            set
            {
                _accountingID = value.ID;
            }
        }

        static public List<Organization> _Organizations = new List<Organization>();
        static public List<Organization> __Organizations = new List<Organization>();

        public Accounting Accountings { get; }

        ~Organization()
        {
                
        }

        public Dictionary<Guid, Organization> Load(int flag)
        {
            if (flag == 1)
            {
                DataContractSerializer dsc = new DataContractSerializer(typeof(Dictionary<Guid, Organization>));
                XmlReader xmlReader = XmlReader.Create("Organizatuion.xml");
                Dictionary<Guid, Organization> result = (Dictionary<Guid, Organization>)dsc.ReadObject(xmlReader);
                xmlReader.Close();
                return result;
            }
            else if (flag == 2)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream binReader = new FileStream("Organization.dat", FileMode.OpenOrCreate);
                Dictionary<Guid, Organization> result = (Dictionary<Guid, Organization>)binaryFormatter.Deserialize(binReader);
                binReader.Close();
                return result;
            }
            else
            {
                DataContractJsonSerializer dcjc = new DataContractJsonSerializer(typeof(Dictionary<Guid, Organization>));
                FileStream jsonReader = new FileStream("Organization.json", FileMode.OpenOrCreate);
                Dictionary<Guid, Organization> result = (Dictionary<Guid, Organization>)dcjc.ReadObject(jsonReader);
                jsonReader.Close();
                return result;
            }
        }

        public void Save()
        {
            DataContractSerializer dsc = new DataContractSerializer(typeof(Dictionary<Guid, Organization>));
            DataContractJsonSerializer dcjc = new DataContractJsonSerializer(typeof(Dictionary<Guid, Organization>));
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            FileStream binWriter = new FileStream("Organization.dat", FileMode.OpenOrCreate);
            XmlWriter xmlWriter = XmlWriter.Create("Organization.xml");
            FileStream jsonWriter = new FileStream("Organization.json", FileMode.OpenOrCreate);

            binaryFormatter.Serialize(binWriter, Organizations);
            dsc.WriteObject(xmlWriter, Organizations);
            dcjc.WriteObject(jsonWriter, Organizations);

            binWriter.Close();
            xmlWriter.Close();
            jsonWriter.Close();
        }

        public override string ToString()
        {
            
            return "Name: " + Name + "/" +
                   "Head: " + Head + "/" +
                   "Year(creat): " + Data_creation + "/" +
                   "Bank account: " + Bank_account + "/" + Exist_organization(Data_creation) +" years";
        }
        




    }
}
