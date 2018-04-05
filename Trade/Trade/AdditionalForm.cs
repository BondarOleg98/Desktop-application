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
    public partial class AdditionalForm : Form
    {
       
        public AdditionalForm()
        {
            InitializeComponent();
           
        }
       
        private void AdditionalForm_Load(object sender, EventArgs e)
        {
            lbСommodity.DataSource = Commodity.Commodities;
            lbOrganization.DataSource = Organization.Organizations.Values.ToList();
            lbItemProduct.DataSource = Item_product.Item_products;
            lbAccounting.DataSource = Accounting.Accountings.Values.ToList();
        }

        private void btChooseOrganizationCommodity_Click(object sender, EventArgs e)
        {
            var org = (Organization)lbOrganization.SelectedItem;
            var com = (Commodity)lbСommodity.SelectedItem;
            СommodityInOrganization cio = new СommodityInOrganization();
            cio.Organization = org;
            cio.Commodity = com;
            СommodityInOrganization.CommodityInOrganizations.Add(cio);
        }

        private void btListOrganizationCommodities_Click(object sender, EventArgs e)
        {
            foreach (Commodity com in ((Organization)lbOrganization.SelectedItem).Commodities)
                Commodity.__Commodities.Add(com);
            foreach (Organization org in ((Commodity)lbСommodity.SelectedItem).Organizations)
                Organization._Organizations.Add(org);
            Refresh_List_Organizations_Commodities();
        }

        private void btListCommodityItemProduct_Click(object sender, EventArgs e)
        {
            Item_product item = (Item_product)lbItemProduct.SelectedItem;
            Commodity comm = (Commodity)lbСommodity.SelectedItem;

            comm.Item_Product = item;
            Item_product._Item_products.Add(item);
            foreach (Commodity com in ((Item_product)lbItemProduct.SelectedItem).Commodities)
                Commodity._Commodities.Add(com);

            Refresh_List_Commodities_Item_Products();
        }

        private void Refresh_List_Organizations_Commodities()
        {
            lbOutComoditiesOrganizations.DataSource = null;
            lbOutComoditiesOrganizations.DataSource = Commodity.__Commodities;
            lbOutOrganizationsComodities.DataSource = null;
            lbOutOrganizationsComodities.DataSource = Organization._Organizations;
        }

        private void Refresh_List_Commodities_Item_Products()
        {
            lbOutComoditiesItemProducts.DataSource = null;
            lbOutComoditiesItemProducts.DataSource = Commodity._Commodities;
            lbOutItemProductsComodities.DataSource = null;
            lbOutItemProductsComodities.DataSource = Item_product._Item_products;
        }

        private void Refresh_List_Organization_Accountings()
        {
            lbOutAccountingsOrganizations.DataSource = null;
            lbOutAccountingsOrganizations.DataSource = Accounting._Accountings;
            lbOutOrganizationsAccountings.DataSource = null;
            lbOutOrganizationsAccountings.DataSource = Organization.__Organizations;
        }

        private void btListOrganizationAccounting_Click(object sender, EventArgs e)
        {
            Organization org = (Organization)lbOrganization.SelectedItem;
            Accounting account = (Accounting)lbAccounting.SelectedItem;
            org.Accounting = account;
            account.Organization = org;
            Organization.__Organizations.Add(org);
            Accounting._Accountings.Add(account);
            Refresh_List_Organization_Accountings();
        }

        private void btClearLinks_Click(object sender, EventArgs e)
        {
            Organization.__Organizations.Clear();
            Accounting._Accountings.Clear();
            Item_product._Item_products.Clear();
            Commodity._Commodities.Clear();
            Commodity.__Commodities.Clear();
            Organization._Organizations.Clear();
            СommodityInOrganization.CommodityInOrganizations.Clear();
            lbOutComoditiesOrganizations.DataSource = null;
            lbOutComoditiesOrganizations.DataSource = Commodity.__Commodities;
            lbOutOrganizationsComodities.DataSource = null;
            lbOutOrganizationsComodities.DataSource = Organization._Organizations;
            lbOutComoditiesItemProducts.DataSource = null;
            lbOutComoditiesItemProducts.DataSource = Commodity._Commodities;
            lbOutItemProductsComodities.DataSource = null;
            lbOutItemProductsComodities.DataSource = Item_product._Item_products;
            lbOutAccountingsOrganizations.DataSource = null;
            lbOutAccountingsOrganizations.DataSource = Accounting._Accountings;
            lbOutOrganizationsAccountings.DataSource = null;
            lbOutOrganizationsAccountings.DataSource = Organization.__Organizations;

        }
    }
}
