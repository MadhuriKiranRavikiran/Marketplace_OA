//using System.Collections.Generic;
//using System.Linq;
//using ServiceLayer.Interfaces;
//using ServiceLayer.Models;
//using DomainLayer.Interfaces;

//namespace ServiceLayer.Services
//{
//    public class ProductsService : IProductsService
//    {
//        private readonly IProductsRepo _productsRepo;

//        public ProductsService(IProductsRepo productsRepo)
//        {
//            _productsRepo = productsRepo;
//        }

//        public IEnumerable<ProductsDTO> GetAllProducts()
//        {
//            // Retrieve products from the repository
//            var products = _productsRepo.GetAllProducts();

//            // Map the repository models to DTO models
//            var productsDTOList = products.Select(p => new ProductsDTO
//            {
//                Product_ID = p.ProductsID,
//                Product_Name = p.Product_Name,
//                Description = p.Description,
//                // You can map other properties as well
//            }).ToList();

//            return productsDTOList;
//        }
//    }
//}
