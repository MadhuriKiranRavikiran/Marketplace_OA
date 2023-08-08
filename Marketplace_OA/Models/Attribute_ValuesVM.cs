using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace_OA.Models
{
    public class Attribute_ValuesVM
    {
        public int Attribute_Value_ID { get; set; }
        public Nullable<int> Attribute_ID { get; set; }
        public string Attribute_Value { get; set; }

        public virtual AttributesVM Attributes { get; set; }
        
        public virtual ICollection<Product_AttributesVM> Product_Attributes { get; set; }
    }

}
