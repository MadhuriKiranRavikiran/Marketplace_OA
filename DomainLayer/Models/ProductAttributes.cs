using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProductAttributes
    {
        public int ProductID { get; set; }
        public int AttributeID { get; set; }
        public int? DiscreteAttributeValueID { get; set; }
        public float? MinContinuousAttributeValue { get; set; }
        public float? MaxContinuousAttributeValue { get; set; }

        public Products Product { get; set; }
        public Attributes Attribute { get; set; }
        public AttributeValues DiscreteAttributeValue { get; set; }
    }
}
