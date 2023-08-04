using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class Product_AttributesDTO
    {
        public int Product_ID { get; set; }
        public int Attribute_ID { get; set; }
        public Nullable<int> Discrete_Attribute_Value_ID { get; set; }
        public Nullable<double> Min_Continuous_Attribute_Value { get; set; }
        public Nullable<double> Max_Continuous_Attribute_Value { get; set; }

        public virtual Attribute_ValuesDTO Attribute_Values { get; set; }
        public virtual AttributesDTO Attributes { get; set; }
        public virtual ProductsDTO Products { get; set; }
    }
}
