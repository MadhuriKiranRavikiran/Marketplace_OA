using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace_OA.Models
{
    public class Product_AttributesVM
    {
        public int Product_ID { get; set; }
        public int Attribute_ID { get; set; }
        public Nullable<int> Discrete_Attribute_Value_ID { get; set; }
        public Nullable<double> Min_Continuous_Attribute_Value { get; set; }
        public Nullable<double> Max_Continuous_Attribute_Value { get; set; }

        public virtual Attribute_ValuesVM Attribute_Values { get; set; }
        public virtual AttributesVM Attributes { get; set; }
        public virtual ProductsVM Products { get; set; }
    }
}
