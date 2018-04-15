using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Configuration;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trade.Data
{
    public class Config
    {
        public string ReadSetting()
        {
            return ConfigurationManager.AppSettings["Test1"];

        }
    }
}
