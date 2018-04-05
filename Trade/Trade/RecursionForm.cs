using Trade.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trade
{
    public partial class RecursionForm : Form
    {
        public RecursionForm()
        {
            InitializeComponent();
        }

        private void btEnterDignity_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(tbEnterDignity.Text) <= 0)
                {
                    throw new Exception();
                }
                Recursion.countA.Add(Convert.ToInt32(tbEnterDignity.Text));
                Recursion.countA.Sort();
                tbEnterDignity.Clear();
                Refresh_Dignity();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: invalid input value");            
                tbEnterDignity.Clear();
            }

        }
        private void btOutputResult_Click(object sender, EventArgs e)
        {
            try
            {
                int count = Recursion.countA.Count;
                int result;
                Recursion.countA.Sort();
                int cost = Convert.ToInt32(tbCostGoods.Text);
                if(cost<=0)
                {
                    throw new Exception();                
                }
                result = Recursion.Pay_for_product(count, cost, Recursion.countA);
                tbTotalMoney.Text = Recursion.Recurs(count).ToString();
                tbOutCost.Text = tbCostGoods.Text;
                tbCostGoods.Clear();

                switch (result)
                {
                    case 1:
                        tbOutResult.Text = "Without change";
                        break;
                    case 2:
                        tbOutResult.Text = "With change(yes or no)";
                        break;
                    case 3:
                        tbOutResult.Text = "Can not pay for a product";
                        break;
                    case 4:
                        tbOutResult.Text = "Magazine can not give change";
                        break;
                } 
            }
            catch (Exception)
            {
                
                MessageBox.Show("Error: invalid input value");
                tbCostGoods.Clear();
            }    

        }
        private void btDeleteDignity_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbOuputDignity.SelectedIndex;
                Recursion.countA.RemoveAt(index);
                Refresh_Dignity();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: did not select value");
            } 
        }

        private void btEditDignity_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbOuputDignity.SelectedIndex;
                Recursion.countA[index] = Convert.ToInt32(tbEnterDignity.Text);
                Refresh_Dignity();
                tbCostGoods.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Invalid input value");
            }
        }
        private void Refresh_Dignity()
        {

            lbOuputDignity.DataSource = null;
            lbOuputDignity.DataSource = Recursion.countA;
        }

        private void btClearResultTotalMoney_Click(object sender, EventArgs e)
        {
            tbOutCost.Clear();
            tbOutResult.Clear();
            tbTotalMoney.Clear();
        }

        private void btClearDignities_Click(object sender, EventArgs e)
        {
            Recursion.countA.Clear();
            Refresh_Dignity();
        }

      
    }
}
