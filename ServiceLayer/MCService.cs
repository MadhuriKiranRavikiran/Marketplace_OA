using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DomainLayer.Interfaces;
using DomainLayer.Models;
using RepositoryLayer;
using RepositoryLayer.Repositories;
using ServiceLayer.Interfaces;
using ServiceLayer.Models;

namespace ServiceLayer
{
    public class MCService : IMainCategoriesService, ICategoriesService

    {
        private readonly MarketDBContext context;

        private Mapper mapper;

        public IUnitOfWork _unitOfWork;

        public MCService()
        {
            context = new MarketDBContext();

            _unitOfWork = new UnitOfWork(context);

            //mapper = new Mapper(new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Categories, CategoriesDTO>();
            //}));


        }

        IEnumerable<MainCategoriesDTO> IMainCategoriesService.GetAllMainCategories()

        {
            var mainCategories = _unitOfWork.MainCategoriesRepo.GetAll();

            List<MainCategoriesDTO> mainCategoriesDTO = new List<MainCategoriesDTO>();

            foreach (var mainCategory in mainCategories)
            {
                mainCategoriesDTO.Add(new MainCategoriesDTO
                {
                    MainCategoriesID = mainCategory.MainCategoriesID,
                    Main_Category_Name = mainCategory.Main_Category_Name,
                });
            }

            return mainCategoriesDTO;
        }


        IEnumerable<CategoriesDTO> ICategoriesService.GetCategoryById(int MainCategoryId)
        {
            var categories = _unitOfWork.CategoriesRepo.GetCategoryById(MainCategoryId);

            List<CategoriesDTO> categoriesDTO = new List<CategoriesDTO>();
            foreach (var category in categories)
            {
                  categoriesDTO.Add(new CategoriesDTO
                  {
                    CategoriesID = category.CategoriesID,
                    Category_Name = category.Category_Name,
                    MainCategoriesID = category.MainCategoriesID,   
                });
            }
            return categoriesDTO;

            //return mapper.Map<List<CategoriesDTO>>(categories);
        }

       
        

        public IEnumerable<Products> GetProductsByCategory(int CategoryId)
        {
            var products = _unitOfWork.ProductsRepo.GetProductsByCategory(CategoryId);

            return (IEnumerable<Products>)mapper.Map<List<ProductsDTO>>(products);
        }

        
    }

 
}
