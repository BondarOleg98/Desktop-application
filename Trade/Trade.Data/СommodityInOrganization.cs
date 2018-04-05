using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data
{
    public class СommodityInOrganization : Base
    {
        static public List<СommodityInOrganization> CommodityInOrganizations = new List<СommodityInOrganization>();

        private Guid _organizationID;
        private Guid _commodityID;

        public Organization Organization
        {
            get
            {
            
                return Organization.Organizations[_organizationID];
            }
            set
            {
                _organizationID = value.ID;
            }
        }
        public Commodity Commodity
        {
            get
            {
                foreach (Commodity commodity in Commodity.Commodities)
                    if (commodity.ID == _commodityID)
                        return commodity;
                return null;
                
            }
            set
            {
                _commodityID = value.ID;
            }
        }
    }
}
