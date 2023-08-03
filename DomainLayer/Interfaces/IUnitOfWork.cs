using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        IProductsRepo ProductsRepo { get; }
        IUsersRepo UsersRepo { get; }
        ICategoriesRepo CategoriesRepo { get; }
        IAttributesRepo AttributesRepo { get; }
        IAttributesCategoryRepo AttributesCategoryRepo { get; }
        IAttributeValuesRepo AttributeValuesRepo { get; }
        IProductAttributesRepo AroductAttributesRepo { get; }


        int Save();
    }
}
