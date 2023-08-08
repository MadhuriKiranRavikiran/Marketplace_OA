using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace_OA.Models
{
    public class ProductsVM
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public string Image_URL { get; set; }
        public Nullable<int> Category_ID { get; set; }

        public virtual CategoriesVM Categories { get; set; }
        
        public virtual ICollection<Product_AttributesVM> Product_Attributes { get; set; }
    }
}
