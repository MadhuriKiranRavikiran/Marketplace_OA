using RepositoryLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using DomainLayer.Interfaces;

namespace RepositoryLayer
{
    public class ProductsRepo : GenericRepo<Products>, IProductsRepo
    {
        public ProductsRepo(MarketDBContext context) : base(context)
        {
        }

        public class ProductAttributesRepo : GenericRepo<Product_Attributes>, IProductAttributesRepo
        {
            public ProductAttributesRepo(MarketDBContext context) : base(context)
            {
            }

            public IEnumerable<Products> GetCategoriesByMainCategoryId(int CategoryID)
            {

                var ProductsList = Context.Set<Categories>()
                       .Include("Categories")
                       .SingleOrDefault(mc => mc.CategoriesID == CategoryID);

                return ProductsList?.Products;
            }
        }
    }

}
