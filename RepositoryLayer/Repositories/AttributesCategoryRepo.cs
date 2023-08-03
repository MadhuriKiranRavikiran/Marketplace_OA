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
    public class AttributeCategoryRepo : GenericRepo<AttributesCategory>, IAttributesCategoryRepo
    {
        public AttributeCategoryRepo(MarketDBContext context) : base(context)
        {
        }
    }

}

