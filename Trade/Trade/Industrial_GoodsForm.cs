using System;
using System.Windows.Forms;
using Trade.Data;


namespace Trade
{
    public partial class Industrial_GoodsForm : Form
    {
        
        public Industrial_GoodsForm()
        {
            InitializeComponent();
        }

        private void lbIndustrial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbIndustrial.SelectedItem != null)
            {
                var industrial = (Industrial)lbIndustrial.SelectedItem;
                tbSize.Text = industrial.Size;
                tbMaterial.Text = industrial.Material;
                tbColor.Text = industrial.Color;
                tbNameGoods.Text = industrial.Name;
                tbCostСommodity.Text = industrial.Cost.ToString();
                tbGenerator.Text = industrial.Generator;
                tbShelfLife.Text = industrial.Shelf_life;
                tbUnitsСommodity.Text = industrial.Units;
            }
        }
        private void Industrial_GoodsForm_Load(object sender, EventArgs e)
        {
            Commodity commodity = new Commodity();
            Commodity._commodities = commodity.Load(1);
            lbIndustrial.DataSource = Commodity._commodities;
           
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbUnitsСommodity.Text != "kg") && (tbUnitsСommodity.Text != "l") && (tbUnitsСommodity.Text != "g"))
                {
                    throw new Exception();
                }

                Industrial industrial = new Industrial(tbSize.Text, tbMaterial.Text, tbColor.Text, tbNameGoods.Text, Convert.ToDouble(tbCostСommodity.Text),
                tbUnitsСommodity.Text, tbGenerator.Text, tbShelfLife.Text);
                Commodity._commodities.Add(industrial);

                Refresh_Goods();

                Clear_Industrial();
                Clear_Commodity();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: invalid input value");

                tbCostСommodity.Clear();
                tbUnitsСommodity.Clear();
            }
        }

        private void Clear_Industrial()
        {
            tbColor.Clear();
            tbSize.Clear();
            tbMaterial.Clear();
        }

        private void Refresh_Goods()
        {
            Commodity commodity = new Commodity();
            commodity.Save(1);
            Commodity._commodities = commodity.Load(1);
            lbIndustrial.DataSource = commodity.Load(1);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbIndustrial.SelectedIndex;
                Commodity._commodities[index] = new Industrial(tbSize.Text, tbMaterial.Text, tbColor.Text, tbNameGoods.Text, Convert.ToDouble(tbCostСommodity.Text),
                tbUnitsСommodity.Text, tbGenerator.Text, tbShelfLife.Text);
                Commodity.Commodities[index] = new Commodity(tbNameGoods.Text, Convert.ToDouble(tbCostСommodity.Text),
                tbUnitsСommodity.Text, tbGenerator.Text, tbShelfLife.Text);
                Refresh_Goods();

                Clear_Commodity();
                Clear_Industrial();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Invalid input value");
            }
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Commodity commodity = new Commodity();
                int index = lbIndustrial.SelectedIndex;
                Commodity._commodities.RemoveAt(index);
                Commodity.Commodities.RemoveAt(index);
                commodity.Save(1);
                lbIndustrial.DataSource = commodity.Load(1);
            }
            catch
            {
                MessageBox.Show("Error: did not select value");
            }
        }

        private void Clear_Commodity()
        {
            tbNameGoods.Clear();
            tbUnitsСommodity.Clear();
            tbCostСommodity.Clear();
            tbGenerator.Clear();
            tbShelfLife.Clear();
        }

    }

}
