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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent(); 
        }


        private void btAddOrganization_Click(object sender, EventArgs e)
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

        private void btEditOrganization_Click(object sender, EventArgs e)
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

        private void btDeleteOrganization_Click(object sender, EventArgs e)
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

        private void Refresh_Organization()
        {
            lbOrganization.DataSource = null;
            lbOrganization.DataSource = Organization.Organizations.Values.ToList();
        }

        private void btAddСommodity_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbUnitsСommodity.Text != "kg") && (tbUnitsСommodity.Text != "l") && (tbUnitsСommodity.Text != "g"))
                {
                    throw new Exception();
                }
                Commodity commodity = new Commodity(tbNameСommodity.Text, Convert.ToDouble(tbCostСommodity.Text),
                tbUnitsСommodity.Text, tbBrandСommodity.Text);
                
                Commodity.Commodities.Add(commodity);
                Refresh_Commodity();
                Refresh_Commodity_Cost();
                Clear_Commodity();

                
            }
            catch
            {
                MessageBox.Show("Error: invalid input value");
                tbCostСommodity.Clear();
                tbUnitsСommodity.Clear();
            }
                
        }

        private void btEditСommodity_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbСommodity.SelectedIndex;
                Commodity.Commodities[index] = new Commodity(tbNameСommodity.Text, Convert.ToDouble(tbCostСommodity.Text),
                    tbUnitsСommodity.Text, tbBrandСommodity.Text);
                Refresh_Commodity();
                Clear_Commodity();
            }
            catch
            {
                MessageBox.Show("Error: Invalid input value");
            }
                
        }

        private void btDeleteСommodity_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbСommodity.SelectedIndex;
                Commodity.Commodities.RemoveAt(index);
                Refresh_Commodity();
            }
            catch
            {
                MessageBox.Show("Error: did not select value");
            }   
        }

        private void Refresh_Commodity()
        {
            lbСommodity.DataSource = null;
            lbСommodity.DataSource = Commodity.Commodities;
        }
        private void Refresh_Commodity_Cost()
        {
           
            lbCommodityCost.DataSource = null;
            lbCommodityCost.DataSource = Commodity.commod_cost;
        }

        private void btAddAccounting_Click(object sender, EventArgs e)
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

        private void btEditAccounting_Click(object sender, EventArgs e)
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

        private void btDeleteAccounting_Click(object sender, EventArgs e)
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

        private void Refresh_Accounting()
        {
            lbAccounting.DataSource = null;
            lbAccounting.DataSource = Accounting.Accountings.Values.ToList();
        }

        private void btAddItemProduct_Click(object sender, EventArgs e)
        {
            
            Item_product.Item_products.Add(new Item_product(tbNameItemProduct.Text, tbSerialNumberItemProduct.Text));
           
            Refresh_Item_Product();
            Clear_Item_Product();
        }

        private void btEditItemProduct_Click(object sender, EventArgs e)
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

        private void btDeleteItemProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbСommodity.SelectedIndex;
                Item_product.Item_products.RemoveAt(index);
                Refresh_Item_Product();
            }
            catch
            {
                MessageBox.Show("Error: did not select value");
            }
           
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

        private void Clear_Commodity()
        {
            tbNameСommodity.Clear();
            tbUnitsСommodity.Clear();
            tbCostСommodity.Clear();
            tbBrandСommodity.Clear();
        }

        private void btTransitionDatabaze_Click(object sender, EventArgs e)
        {

            AdditionalForm additional = new AdditionalForm();
            additional.Owner = this;
            additional.ShowDialog();
        }

        private void btEnterRecursion_Click(object sender, EventArgs e)
        {
            RecursionForm recursion = new RecursionForm();
            recursion.Owner = this;
            recursion.ShowDialog();
        }

        private void lbOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbOrganization.SelectedItem!=null)
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

        private void lbСommodity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbСommodity.SelectedItem != null)
            {
                var commodity = (Commodity)lbСommodity.SelectedItem;
                tbBrandСommodity.Text = commodity.Brand;
                tbCostСommodity.Text = commodity.Cost.ToString();
                tbNameСommodity.Text = commodity.Name;
                tbUnitsСommodity.Text = commodity.Units;
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
            Organization organization1 = new Organization("Phenix", 2016, "2019-ca-12", "Yashch");
            Organization.Organizations.Add(organization1.ID, organization1);
            Organization organization2 = new Organization("Space", 2017, "2018-ca-12", "Shchyr");
            Organization.Organizations.Add(organization2.ID, organization2);
            Organization organization3 = new Organization("Apple", 2013, "2010-bv-12", "Valiev");
            Organization.Organizations.Add(organization3.ID, organization3);
            Refresh_Organization();

            Commodity commodity1 = new Commodity("Potatoes",2.34, "kg", "-");
            Commodity.Commodities.Add(commodity1);
            Commodity commodity2 = new Commodity("Oranges", 10.0, "kg", "-");
            Commodity.Commodities.Add(commodity2);
            Commodity commodity3 = new Commodity("Tomatoes", 12.34, "kg", "-");
            Commodity.Commodities.Add(commodity3);
            Refresh_Commodity();

            Item_product item_Product1 = new Item_product("Vegetables", "62345");
            Item_product.Item_products.Add(item_Product1);
            Item_product item_Product2 = new Item_product("Fruits", "09752");
            Item_product.Item_products.Add(item_Product2);
            Item_product item_Product3 = new Item_product("Vegetables", "18435");
            Item_product.Item_products.Add(item_Product3);
            Refresh_Item_Product();

            Accounting accounting1 = new Accounting(20, 10,  1000);
            Accounting.Accountings.Add(accounting1.ID, accounting1);
            Accounting accounting2 = new Accounting(20, 30, 2500);
            Accounting.Accountings.Add(accounting2.ID, accounting2);
            Accounting accounting3 = new Accounting(15, 15, 1520);
            Accounting.Accountings.Add(accounting3.ID, accounting3);
            
            Refresh_Accounting();
        }

        private void btIndex_Click(object sender, EventArgs e)
        {
            Commodity commodity = new Commodity();
            int index;
            try
            {
                index = Convert.ToInt16(tbIndexator.Text);
                MessageBox.Show(commodity[index].Name);
                lbCommodityCost.DataSource = null;
                lbCommodityCost.DataSource = Commodity.commod_cost;
            }
            catch (Exception)
            {
                MessageBox.Show("Error: number is not valid");

            }
            tbIndexator.Clear();
           
        }

    }
}
