using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class MainCategoriesDTO
    {
        public int Main_Category_ID { get; set; }
        public string Main_Category_Name { get; set; }

        public virtual ICollection<CategoriesDTO> Categories { get; set; }
    }
}
