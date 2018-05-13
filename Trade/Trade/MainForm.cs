using Trade.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Trade
{
    public partial class MainForm : Form
    {
  
        public MainForm()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (rbOrganizations.Checked)
            {
                try
                {
                    var value = new Organization(tbNameOrganization.Text,
                    Convert.ToInt32(tbDataCreationOrganization.Text), tbBankAccountOrganization.Text,
                    tbHeadOrganization.Text);

                    if (Convert.ToInt32(tbDataCreationOrganization.Text) <= 1980)
                    {
                        throw new Exception();
                    }
                    Organization.Organizations.Add(value.ID, value);

                    Refresh_Organization();

                    Clear_Organization();
                }

                catch (Exception)
                {
                    MessageBox.Show("Error: invalid input value");
                    tbDataCreationOrganization.Clear();
                }
            }
            else if (rbAccountings.Checked)
            {
                try
                {
                    var value = new Accounting(Convert.ToInt32(tbNumberSold.Text),
                    Convert.ToInt32(tbNumberAcquired.Text), Convert.ToDouble(tbCapitalOrganization.Text));
                    Accounting.Accountings.Add(value.ID, value);
                    Refresh_Accounting();
                    Clear_Accounting();
                }
                catch
                {
                    MessageBox.Show("Error: invalid input value");
                    tbNumberAcquired.Clear();
                    tbNumberSold.Clear();
                    tbCapitalOrganization.Clear();
                }
            }
            else if (rbItemProduct.Checked)
            {
                Item_product.Item_products.Add(new Item_product(tbNameItemProduct.Text, tbSerialNumberItemProduct.Text));

                Refresh_Item_Product();
                Clear_Item_Product();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (rbOrganizations.Checked)
            {
                try
                {
                    var id = (Organization)lbOrganization.SelectedItem;
                    var newvalue = new Organization(tbNameOrganization.Text,
                    Convert.ToInt32(tbDataCreationOrganization.Text), tbBankAccountOrganization.Text,
                    tbHeadOrganization.Text);

                    Organization.Organizations.Remove(id.ID);
                    Organization.Organizations.Add(newvalue.ID, newvalue);

                    Refresh_Organization();
                    Clear_Organization();
                }
                catch
                {
                    MessageBox.Show("Error: Invalid input value");
                }
            }
            else if (rbAccountings.Checked)
            {
                try
                {
                    var value = (Accounting)lbAccounting.SelectedItem;
                    var newvalue = new Accounting(Convert.ToInt32(tbNumberSold.Text),
                        Convert.ToInt32(tbNumberAcquired.Text), Convert.ToDouble(tbCapitalOrganization.Text));
                    Accounting.Accountings.Remove(value.ID);
                    Accounting.Accountings.Add(newvalue.ID, newvalue);
                    Refresh_Accounting();
                    Clear_Accounting();
                }
                catch
                {
                    MessageBox.Show("Error: Invalid input value");
                }
            }
            
            else if (rbItemProduct.Checked)
            {
                try
                {
                    int index = lbItemProduct.SelectedIndex;
                    Item_product.Item_products[index] = new Item_product(tbNameItemProduct.Text, tbSerialNumberItemProduct.Text);
                    Refresh_Item_Product();
                    Clear_Item_Product();
                }
                catch
                {
                    MessageBox.Show("Error: Invalid input value");
                }
            }      
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (rbOrganizations.Checked)
            {
                try
                {
                    var id = (Organization)lbOrganization.SelectedItem;
                    Organization.Organizations.Remove(id.ID);
                    
                    Refresh_Organization();
                }
                catch
                {
                    MessageBox.Show("Error: did not select value");
                }
            }
            else if (rbAccountings.Checked)
            {
                try
                {
                    var value = (Accounting)lbAccounting.SelectedItem;
                    Accounting.Accountings.Remove(value.ID);
                    Refresh_Accounting();
                }
                catch
                {
                    MessageBox.Show("Error: did not select value");
                }
            }
            else if (rbItemProduct.Checked)
            {
                try
                {
                    int index = lbGoods.SelectedIndex;
                    Item_product.Item_products.RemoveAt(index);
                    Refresh_Item_Product();
                }
                catch
                {
                    MessageBox.Show("Error: did not select value");
                }
            }
        }

        private void Refresh_Organization()
        {
            lbOrganization.DataSource = null;
            lbOrganization.DataSource = Organization.Organizations.Values.ToList();
        }

        private void Refresh_Accounting()
        {
            lbAccounting.DataSource = null;
            lbAccounting.DataSource = Accounting.Accountings.Values.ToList();
        }

        private void Refresh_Item_Product()
        {
            lbItemProduct.DataSource = null;
            lbItemProduct.DataSource = Item_product.Item_products;
        }

        private void Clear_Item_Product()
        {
            tbNameItemProduct.Clear();
            tbSerialNumberItemProduct.Clear();
        }

        private void Clear_Organization()
        {
            tbNameOrganization.Clear();
            tbHeadOrganization.Clear();
            tbBankAccountOrganization.Clear();
            tbDataCreationOrganization.Clear();
        }

        private void Clear_Accounting()
        {
            tbNumberSold.Clear();
            tbNumberAcquired.Clear();
            tbCapitalOrganization.Clear();
        }

 

        private void btTransitionDatabaze_Click(object sender, EventArgs e)
        {

            AdditionalForm additional = new AdditionalForm();
            additional.Owner = this;
            additional.ShowDialog();
        }

        private void lbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOrganization.SelectedItem != null)
            {
                var organization = (Organization)lbOrganization.SelectedItem;

                tbBankAccountOrganization.Text = organization.Bank_account;
                tbDataCreationOrganization.Text = organization.Data_creation.ToString();
                tbHeadOrganization.Text = organization.Head;
                tbNameOrganization.Text = organization.Name;
            }
        }

        private void lbAccounting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAccounting.SelectedItem != null)
            {
                var accounting = (Accounting)lbAccounting.SelectedItem;
                tbNumberSold.Text = accounting.Number_sold.ToString();
                tbNumberAcquired.Text = accounting.Number_acquired.ToString();
                tbCapitalOrganization.Text = accounting.Capital_organization.ToString();
            }
        }

        private void lbItemProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbItemProduct.SelectedItem != null)
            {
                var item_product = (Item_product)lbItemProduct.SelectedItem;
                tbNameItemProduct.Text = item_product.Name;
                tbSerialNumberItemProduct.Text = item_product.serial_number;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbNumberSold.Enabled = false;
            tbNumberAcquired.Enabled = false;
            tbSerialNumberItemProduct.Enabled = false;
            tbCapitalOrganization.Enabled = false;
            tbNameItemProduct.Enabled = false;

            Organization organization = new Organization();
            Organization.Organizations = organization.Load(2);
            lbOrganization.DataSource = Organization.Organizations.Values.ToList();

            Commodity commodity = new Commodity();
            Commodity.Commodities = commodity.Load(2);
            lbGoods.DataSource = Commodity.Commodities;

            Item_product item_Product1 = new Item_product("Fish", "62345");
            Item_product.Item_products.Add(item_Product1);
            Item_product item_Product2 = new Item_product("Fruits", "09752");
            Item_product.Item_products.Add(item_Product2);
            Item_product item_Product3 = new Item_product("Vegetables", "18435");
            Item_product.Item_products.Add(item_Product3);
            Refresh_Item_Product();

            Accounting accounting1 = new Accounting(20, 10, 1000);
            Accounting.Accountings.Add(accounting1.ID, accounting1);
            Accounting accounting2 = new Accounting(20, 30, 2500);
            Accounting.Accountings.Add(accounting2.ID, accounting2);
            Accounting accounting3 = new Accounting(15, 15, 1520);
            Accounting.Accountings.Add(accounting3.ID, accounting3);
            Refresh_Accounting(); 
        }

        private void btIndexerStaticMethod_Click(object sender, EventArgs e)
        {
            Indexer_StaticMethod indexer_StaticMethod = new Indexer_StaticMethod();
            indexer_StaticMethod.ShowDialog();
        }

        private void btIndustrialGoods_Click(object sender, EventArgs e)
        {                      
            Industrial_GoodsForm industrial_Goods = new Industrial_GoodsForm();
            industrial_Goods.ShowDialog();                       
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Commodity commodity = new Commodity();

            Commodity.Commodities.Clear();
            Commodity.Commodities.AddRange(commodity.Load(1));
            Commodity.Commodities.AddRange(Products.Load_product(1));
            Commodity.Commodities.AddRange(Products.Load_product(2));
            lbGoods.DataSource = null;
            lbGoods.DataSource = Commodity.Commodities;
        }

        private void btProducts_Click(object sender, EventArgs e)
        {
            Products_GoodsForm products_GoodsForm = new Products_GoodsForm();
            products_GoodsForm.ShowDialog();
        }

        private void rbOrganizations_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrganizations.Checked)
            {
                tbNumberSold.Enabled = false;
                tbNumberAcquired.Enabled = false;
                tbSerialNumberItemProduct.Enabled = false;
                tbCapitalOrganization.Enabled = false;
                tbNameItemProduct.Enabled = false;
            }
            else
            {
                tbNumberSold.Enabled = true;
                tbNumberAcquired.Enabled = true;
                tbSerialNumberItemProduct.Enabled = true;
                tbCapitalOrganization.Enabled = true;
                tbNameItemProduct.Enabled = true;
            }
        }

        private void rbAccountings_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAccountings.Checked)
            {
                tbNameOrganization.Enabled = false;
                tbHeadOrganization.Enabled = false;
                tbBankAccountOrganization.Enabled = false;
                tbDataCreationOrganization.Enabled = false;
                tbSerialNumberItemProduct.Enabled = false;
                tbNameItemProduct.Enabled = false;
            }
            else
            {
                tbNameOrganization.Enabled = true;
                tbHeadOrganization.Enabled = true;
                tbBankAccountOrganization.Enabled = true;
                tbDataCreationOrganization.Enabled = true;
                tbSerialNumberItemProduct.Enabled = true;
                tbNameItemProduct.Enabled = true;
            }
        }

        private void rbItemProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbItemProduct.Checked)
            {
                tbNumberSold.Enabled = false;
                tbNumberAcquired.Enabled = false;
                tbCapitalOrganization.Enabled = false;
                tbNameOrganization.Enabled = false;
                tbHeadOrganization.Enabled = false;
                tbBankAccountOrganization.Enabled = false;
                tbDataCreationOrganization.Enabled = false;
            }
            else
            {
                tbNumberSold.Enabled = true;
                tbNumberAcquired.Enabled = true;
                tbCapitalOrganization.Enabled = true;
                tbNameOrganization.Enabled = true;
                tbHeadOrganization.Enabled = true;
                tbBankAccountOrganization.Enabled = true;
                tbDataCreationOrganization.Enabled = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Organization organization = new Organization();
            organization.Save();
        }
    }
}
