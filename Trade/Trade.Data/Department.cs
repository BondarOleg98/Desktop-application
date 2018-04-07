using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data
{
    public class Department : Organization
    {
        public string Name_depart { get; private set;}

        public Department(string name_depart, string name_org, int data_creation, string bank_account, string head) 
            : base(name_org, data_creation, bank_account, head)
        {
            Name_depart = name_depart;
        }

        public override string ToString()
        {
            return "Departameent: "+ Name_depart;
        }

    }
}
