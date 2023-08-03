using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class MainCategoriesRepo : GenericRepo<MainCategories>, IMainCategoriesRepo
    {
        public MainCategoriesRepo(MarketDBContext context) : base(context)
        {
        }
    }

}
