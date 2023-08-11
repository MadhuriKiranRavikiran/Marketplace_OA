using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marketplace_OA.Models
{
    public class FilterView
    {
        public int AttributesID { get; set; }
        public string Attribute_Name { get; set; }
        public Nullable<int> Attribute_Max { get; set; }
        public Nullable<int> Attribute_Min { get; set; }
    }
}