using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class AttributeValues
    {
        public int AttributeValueID { get; set; }
        public int AttributeID { get; set; }
        public string AttributeValueName { get; set; }

        public Attributes Attribute { get; set; }
    }

}
