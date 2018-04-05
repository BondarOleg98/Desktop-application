using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data
{
    public class Expense_income
    {
        static public List<Expense_income> Expense_incomes = new List<Expense_income>();

        public double Expense { get; private set; }
        public double Income { get; private set; }

        public Expense_income(double expense, double income)
        {
            Expense = expense;
            Income = income;
        }

    }
}
