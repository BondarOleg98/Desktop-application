using System;
using System.Runtime.Serialization;

namespace Trade.Data
{
    [Serializable]
    [DataContract]
    public class Base
    {
        [DataMember]
        public Guid ID {get; set;}

        public Base()
        {
            ID = Guid.NewGuid();
        }
    }
}
