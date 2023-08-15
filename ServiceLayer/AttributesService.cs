using AutoMapper;
using DomainLayer.Models;
using RepositoryLayer.Repositories;
using RepositoryLayer;
using ServiceLayer.Interfaces;
using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Interfaces;

namespace ServiceLayer
{
    public class AttributesService : IAttributesService
    {
        MarketDBContext context = new MarketDBContext();
        private Mapper mapper;
        public IUnitOfWork _unitOfWork;
        public AttributesService()
        {
            context = new MarketDBContext();
            _unitOfWork = new UnitOfWork(context);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product_Attributes, Product_AttributesDTO>();

                cfg.CreateMap<Attributes, AttributesDTO>();

            });
            mapper = new Mapper(config);
        }
        IEnumerable<AttributesDTO> IAttributesService.GetAttribute(int CategoriesID)
        {
            var attributes = mapper.Map<List<AttributesDTO>>(_unitOfWork.AttributesRepo.GetAttributeByCategoryId(CategoriesID));
            return attributes;
        }
    }
}
