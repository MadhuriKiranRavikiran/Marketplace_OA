using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class AttributesCategory
    {
        public int CategoryID { get; set; }
        public int AttributeCategoryID { get; set; }

        public Categories Category { get; set; }
        public Attributes AttributeCategory { get; set; }
    }
}
