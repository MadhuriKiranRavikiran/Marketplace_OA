using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marketplace_OA.Models
{
    public class FilteredViewModel
    {
        public List<AttributeFilter> Attributes { get; set; }
        public string MainCategory { get; set; }
        public string SubCategory { get; set; }

        public class AttributeFilter
        {
            public int CategoriesID { get; set; }
            public int AttributeId { get; set; }
            public int SelectedMaxValue { get; set; }
            public int SelectedMinValue { get; set; }

        }
        //public FilteredViewModel()
        //{
        //    Attributes = new List<AttributeFilter>();
        //}

    }
}