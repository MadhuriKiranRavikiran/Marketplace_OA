﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class ProductsDTO
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public string Image_URL { get; set; }
        public Nullable<int> Category_ID { get; set; }

        public virtual CategoriesDTO Categories { get; set; }
        
        public virtual ICollection<Product_AttributesDTO> Product_Attributes { get; set; }
    }
}
