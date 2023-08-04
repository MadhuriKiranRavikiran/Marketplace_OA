using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class CategoriesDTO
    {
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public Nullable<int> Main_Category_ID { get; set; }


        public virtual MainCategories MainCategories { get; set; }
        
        public virtual ICollection<Products> Products { get; set; }
        
        public virtual ICollection<Attributes> Attributes { get; set; }
    }
}
