using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Models;
using DomainLayer.Interfaces;
using DomainLayer.Models;
using RepositoryLayer;
using RepositoryLayer.Repositories;


namespace ServiceLayer.Interfaces


{
    public interface IAttributesService
    {
        //IEnumerable<AttributesDTO> GetAttributes();
        IEnumerable<AttributesDTO> GetAttribute(int CategoriesID);
    }

}
