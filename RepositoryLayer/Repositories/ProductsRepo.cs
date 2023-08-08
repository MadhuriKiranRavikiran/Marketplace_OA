using RepositoryLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using DomainLayer.Interfaces;
using System.Runtime.Remoting.Contexts;

namespace RepositoryLayer
{
    public class ProductsRepo : GenericRepo<Products>, IProductsRepo
    {
        public ProductsRepo(MarketDBContext context) : base(context)
        {
        }
        public IEnumerable<Products> GetProductsByCategory(int CategoryId)
        {

            var ProductsList = Context.Set<Products>().Where(category => category.CategoriesID == CategoryId);

            // For testing purposes
            //foreach(var product in ProductsList)
            //{
            //    Console.WriteLine(product);
            //}

            return ProductsList;
        }
        
    }

}
