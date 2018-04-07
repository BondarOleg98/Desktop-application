using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data
{
    public class Manager : Department
    {
        static List<Manager> manager = new List<Manager>();

        public string Name_manager { get; private set; }

        public Manager(string name_manager, string name_depart, 
             string name_org, int data_creation, string bank_account, string head) 
            : base(name_depart, name_org, data_creation, bank_account, head)
        {
            Name_manager = name_manager;
        }

        public override string ToString()
        {
            return "Manager: " + Name_manager;
        }
    }
}
