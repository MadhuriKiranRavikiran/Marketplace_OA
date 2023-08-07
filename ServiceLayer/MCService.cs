using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DomainLayer.Interfaces;
using RepositoryLayer;
using RepositoryLayer.Repositories;
using ServiceLayer.Interfaces;
using ServiceLayer.Models;

namespace ServiceLayer
{
    public class MCService : IMainCategoriesService

    {
        MarketDBContext context = new MarketDBContext();
        
        private Mapper mapper;

        public IUnitOfWork _unitOfWork;

        public MCService()
        {
            context = new MarketDBContext();

            _unitOfWork = new UnitOfWork(context);

            mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MCService,MainCategoriesDTO>();
            }));
        }

        IEnumerable<MainCategoriesDTO> IMainCategoriesService.GetAllMainCategories()
        {
            return mapper.Map<List<MainCategoriesDTO>>(_unitOfWork.MainCategoriesRepo.GetAll());
        }

    }
}
