using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Marketplace_OA.Models
{
    public class AttributesVM
    {
        public int Attribute_ID { get; set; }
        public string Attribute_Name { get; set; }
        public Nullable<double> min_value { get; set; }
        public Nullable<double> max_value { get; set; }
        public string Value_Type { get; set; }

        
        public virtual ICollection<Attribute_ValuesVM> Attribute_Values { get; set; }
        
        public virtual ICollection<Product_AttributesVM> Product_Attributes { get; set; }
        
        public virtual ICollection<CategoriesVM> Categories { get; set; }
    }
}
