using System;
using Trade.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trade
{
    public partial class ConfigSetting : Form
    {
        public ConfigSetting()
        {
            InitializeComponent();
        }

        private void btShowSettings_Click(object sender, EventArgs e)
        {
            tbSetting.Text = ConfigurationManager.AppSettings["Test1"];
        }

        private void ConfigSetting_Load(object sender, EventArgs e)
        {
  
        }
    }
}
