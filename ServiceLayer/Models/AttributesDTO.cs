using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class AttributesDTO
    {
        public int Attribute_ID { get; set; }
        public string Attribute_Name { get; set; }
        public Nullable<double> min_value { get; set; }
        public Nullable<double> max_value { get; set; }
        public string Value_Type { get; set; }

        
        public virtual ICollection<Attribute_Values> Attribute_Values { get; set; }
        
        public virtual ICollection<Product_Attributes> Product_Attributes { get; set; }
        
        public virtual ICollection<Categories> Categories { get; set; }
    }
}
