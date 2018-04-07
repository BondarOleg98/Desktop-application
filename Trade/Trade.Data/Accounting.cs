using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trade.Data
{
    public class Accounting : Base
    {
        static public Dictionary<Guid, Accounting> Accountings = new Dictionary<Guid, Accounting>();
        static public List<Accounting> _Accountings = new List<Accounting>();

        public int Number_sold { get; private set; }
        public int Number_acquired { get; private set; }
        public double Capital_organization { get; private set; }

        readonly int Remainder;
        private string _Remainder { get; set; }


        private Guid _organizationID;

        public Accounting(int number_sold, int number_acquired, double capital_organization)
        {
            Number_sold = number_sold;
            Number_acquired = number_acquired;
            Capital_organization = capital_organization;

            Remainder =registration(Number_sold, Number_acquired);
        
            _Remainder = registration();
        }
        public Accounting() { }

        static private int registration(int Number_sold, int Number_acquired)
        {
            int remainder = Number_acquired - Number_sold;
            if(remainder==0)
            {
                return 0;
            }
            else if (remainder < 0)
            {
                return 0;
            }
            else
            {
                return remainder;
            }
        }

        private string registration()
        {
            int goods = registration(Number_sold, Number_acquired);
            if (Number_acquired < Number_sold)
            {
                return "Sold more on: " + Math.Abs(Number_acquired-Number_sold);
            }
            else if(goods == 0)
            {
                return "No goods";
            }
            else
            {
                return "Expense:" + goods;
            }
        }

        public Organization Organization
        {
            get
            {
                return Organization.Organizations[_organizationID];
            }
            set
            {
                _organizationID = value.ID;
            }
        }

        ~Accounting() { }

        public override string ToString()
        {
            return "Capital: " + Capital_organization + "/" +
                   " Num(acquired): " + Number_acquired + "/" +
                   " Num(sold): " + Number_sold + "/" +
                   " Remain(goods): " + Remainder+ "/"+ _Remainder;
        }

    }
}
