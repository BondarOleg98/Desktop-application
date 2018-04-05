using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Data
{
    public class Base
    {
        public Guid ID {get; private set;}

        public Base()
        {
            ID = Guid.NewGuid();
        }
    }
}
