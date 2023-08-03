using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Attributes
    {
        public int AttributeID { get; set; }
        public string AttributeName { get; set; }
        public float? MinValue { get; set; }
        public float? MaxValue { get; set; }
        public string ValueType { get; set; }

        public ICollection<ProductAttributes> ProductAttributes { get; set; }
    }
}
