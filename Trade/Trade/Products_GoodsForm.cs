using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trade.Data;

namespace Trade
{
    public partial class Products_GoodsForm : Form
    {
        public Products_GoodsForm()
        {
            InitializeComponent();
        }

        private void rbMilk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMilk.Checked)
            {
                tbGoodCanned.Enabled = false;
                tbTypeFish.Enabled = false;
            }
            else
            {
                tbGoodCanned.Enabled = true;
                tbTypeFish.Enabled = true;
            }
        }

        private void rbFish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFish.Checked)
            {
                tbTypeMilk.Enabled = false;
                tbMilkProduct.Enabled = false;
                tbFatContent.Enabled = false;
            }
            else
            {
                tbTypeMilk.Enabled = true;
                tbMilkProduct.Enabled = true;
                tbFatContent.Enabled = true;
            }
        }

        private void Products_GoodsForm_Load(object sender, EventArgs e)
        {
            tbGoodCanned.Enabled = false;
            tbTypeFish.Enabled = false;

            Products.Product_milk = Products.Load_product(1);
            lbMilkProduct.DataSource = Products.Load_product(1);
            Products.Product_fish = Products.Load_product(2);
            lbFishProduct.DataSource = Products.Load_product(2);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (rbMilk.Checked)
            {
                try
                {
                    if ((tbUnitsСommodity.Text != "kg") && (tbUnitsСommodity.Text != "l") && (tbUnitsСommodity.Text != "g"))
                    {
                        throw new Exception();
                    }

                    MilkProducts milkProducts = new MilkProducts(Convert.ToDouble(tbFatContent.Text), tbMilkProduct.Text, tbTypeMilk.Text, tbThread.Text, tbPackage.Text, tbNameGoods.Text, Convert.ToDouble(tbCostСommodity.Text),
                    tbUnitsСommodity.Text, tbGenerator.Text, tbShelfLife.Text);
                    Products.Product_milk.Add(milkProducts);
                  
                    Refresh_Milk_Goods();

                    Clear_Commodity();
                    Clear_Milk_Products();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: invalid input value");

                    tbCostСommodity.Clear();
                    tbUnitsСommodity.Clear();
                }
            }
            else if (rbFish.Checked)
            {
                try
                {
                    if ((tbUnitsСommodity.Text != "kg") && (tbUnitsСommodity.Text != "l") && (tbUnitsСommodity.Text != "g"))
                    {
                        throw new Exception();
                    }

                    FishProducts fishProducts = new FishProducts(tbGoodCanned.Text, tbTypeFish.Text, tbThread.Text, tbPackage.Text, tbNameGoods.Text, Convert.ToDouble(tbCostСommodity.Text),
                       tbUnitsСommodity.Text, tbGenerator.Text, tbShelfLife.Text);
                    Products.Product_fish.Add(fishProducts);

                    Refresh_Fish_Goods();
                    Clear_Commodity();
                    Clear_Fish_Products();
                }
                catch (Exception)
            {
                MessageBox.Show("Error: invalid input value");

                tbCostСommodity.Clear();
                tbUnitsСommodity.Clear();
            }
        }

    }
        private void Refresh_Milk_Goods()
        {
            Products products = new Products();

            products.Save(1);
            Products.Product_milk = Products.Load_product(1);
            lbMilkProduct.DataSource = Products.Load_product(1);

        }
        private void Refresh_Fish_Goods()
        {
            lbFishProduct.DataSource = null;
            lbFishProduct.DataSource = Products.Product_fish;
        }

        private void Clear_Product()
        {
            tbThread.Clear();
            tbPackage.Clear();

        }
        private void Clear_Milk_Products()
        {
            tbMilkProduct.Clear();
            tbTypeMilk.Clear();
            tbFatContent.Clear();
            tbThread.Clear();
            tbPackage.Clear();
        }
        private void Clear_Fish_Products()
        {
            tbTypeFish.Clear();
            tbGoodCanned.Clear();
            tbThread.Clear();
            tbPackage.Clear();
        }

        private void Clear_Commodity()
        {
            tbNameGoods.Clear();
            tbUnitsСommodity.Clear();
            tbCostСommodity.Clear();
            tbGenerator.Clear();
            tbShelfLife.Clear();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (rbFish.Checked)
            {
                try
                {
                    int index = lbFishProduct.SelectedIndex;
                    Products.Product_fish[index] = new FishProducts(tbGoodCanned.Text, tbTypeFish.Text, tbThread.Text, tbPackage.Text, tbNameGoods.Text, Convert.ToDouble(tbCostСommodity.Text),
                    tbUnitsСommodity.Text, tbGenerator.Text, tbShelfLife.Text);
                    Commodity.Commodities[index] = new Commodity(tbNameGoods.Text, Convert.ToDouble(tbCostСommodity.Text),
                    tbUnitsСommodity.Text, tbGenerator.Text, tbShelfLife.Text);

                    Refresh_Fish_Goods();
                    
                    Clear_Commodity();
                    Clear_Milk_Products();
                }
                catch
                {
                    MessageBox.Show("Error: Invalid input value");

                }
            }
            else if(rbMilk.Checked)
            {
                try
                {
                    int index = lbMilkProduct.SelectedIndex;
                    Products.Product_milk[index] = new MilkProducts(Convert.ToDouble(tbFatContent.Text), tbMilkProduct.Text, tbTypeMilk.Text, tbThread.Text, tbPackage.Text, tbNameGoods.Text, Convert.ToDouble(tbCostСommodity.Text),
                    tbUnitsСommodity.Text, tbGenerator.Text, tbShelfLife.Text);

                    Refresh_Milk_Goods();

                    Clear_Commodity();
                    Clear_Fish_Products();
                }
                catch
                {
                    MessageBox.Show("Error: Invalid input value");
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (rbMilk.Checked)
            {
                //try
                //{
                    Products products = new Products();
                    int index =lbMilkProduct.SelectedIndex;
                    Products.Product_milk.RemoveAt(index);
                    Commodity.Commodities.RemoveAt(index);
                    products.Save(1);
                    lbMilkProduct.DataSource = Products.Load_product(1);
                //}
                //catch
                //{
                //    MessageBox.Show("Error: did not select value");
                //}
            }
            else if (rbFish.Checked)
            {
                //try
                //{
                    Products products = new Products();
                    int index = lbFishProduct.SelectedIndex;
                    Products.Product_fish.RemoveAt(index);
                    Commodity.Commodities.RemoveAt(index);
                    products.Save(2);
                    lbFishProduct.DataSource = Products.Load_product(2);
                //}
                //catch
                //{
                //    MessageBox.Show("Error: did not select value");
                //}
            }
           
        }

        private void lbMilkProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMilkProduct.SelectedItem != null)
            {
                var milk_product = (MilkProducts)lbMilkProduct.SelectedItem;
                tbFatContent.Text = milk_product.Fat_content.ToString();
                tbMilkProduct.Text = milk_product.Milk_products;
                tbTypeMilk.Text = milk_product.Type_milk_product;
                tbThread.Text = milk_product.Thread;
                tbPackage.Text = milk_product.Package;
                tbNameGoods.Text = milk_product.Name;
                tbCostСommodity.Text = milk_product.Cost.ToString();
                tbGenerator.Text = milk_product.Generator;
                tbShelfLife.Text = milk_product.Shelf_life;
                tbUnitsСommodity.Text = milk_product.Units;
            }
        }

        private void lbFishProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFishProduct.SelectedItem != null)
            {
                var fishproduct = (FishProducts)lbFishProduct.SelectedItem;
                tbGoodCanned.Text = fishproduct.Goods_canned;
                tbTypeFish.Text = fishproduct.Type_fish;
                tbThread.Text = fishproduct.Thread;
                tbPackage.Text = fishproduct.Package;
                tbNameGoods.Text = fishproduct.Name;
                tbCostСommodity.Text = fishproduct.Cost.ToString();
                tbGenerator.Text = fishproduct.Generator;
                tbShelfLife.Text = fishproduct.Shelf_life;
                tbUnitsСommodity.Text = fishproduct.Units;
            }
        }

        private void Products_GoodsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Products products = new Products();
            products.Save(2);
        }
    }
}
