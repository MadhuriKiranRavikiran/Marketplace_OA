using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using ServiceLayer.Models;

namespace ServiceLayer.Interfaces
{

    public interface IProductsService
    {
        IEnumerable<ProductsDTO> GetProductsByCategory(int CategoryId);

        IEnumerable<ProductAttributeDetailDTO> GetProductAttributeByID(int productId);
    }

}