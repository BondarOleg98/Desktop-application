using System;
using System.Windows.Forms;
using Trade.Data;

namespace Trade
{
    public partial class Indexer_StaticMethod : Form
    {
        public Indexer_StaticMethod()
        {
            InitializeComponent();
        }

        private void btIndex_Click(object sender, EventArgs e)
        {
            Commodity commodity = new Commodity();
            int index;
            try
            {
                index = Convert.ToInt16(tbIndexator.Text);
                MessageBox.Show(commodity[index].Name);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: number is not valid");

            }
            tbIndexator.Clear();
        }
        private void btCommoditiesCost_Click(object sender, EventArgs e)
        {
            lbCommodityCost.DataSource = null;
            lbCommodityCost.DataSource = Commodity.Commodity_Cost();
        }


    }

}
