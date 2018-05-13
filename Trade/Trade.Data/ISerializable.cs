using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data
{
    interface ISerializable
    {
        void Save();
        Dictionary<Guid, Organization> Load(int flag);
    }
}
