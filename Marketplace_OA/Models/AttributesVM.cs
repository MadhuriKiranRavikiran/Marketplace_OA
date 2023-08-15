using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marketplace_OA.Models
{
    public class AttributesVM
    {
        public int AttributesID { get; set; }
        public string Attribute_Name { get; set; }
        public Nullable<double> min_value { get; set; }
        public Nullable<double> max_value { get; set; }
        public string Value_Type { get; set; }

        public int CategoriesID { get; set; }
    }
}