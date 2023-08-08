using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Marketplace_OA.Models;
using ServiceLayer;
using ServiceLayer.Interfaces;
using ServiceLayer.Models;

namespace Marketplace_OA.Controllers
{
    
    public class HomeController : Controller
    {
        public IMainCategoriesService _mainCategoriesService;
        public ICategoriesService _categoriesService;
        public IProductGetAttributeService _productsService;

        public Mapper _mapper;

        public HomeController()
        {
            _mainCategoriesService = new MCService();
            _categoriesService = new MCService();
            _productsService = new MCService();
            //_mapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CategoriesDTO,CategoriesVM>()));

        }

        public ActionResult MainCategories()
        {
            var mainCategories = _mainCategoriesService.GetAllMainCategories();
            //var mainCategoriesVM = _mapper.Map<List<MainCategoriesVM>>(mainCategories);
            List<MainCategoriesVM> mainCategoriesVM = new List<MainCategoriesVM>();

            foreach (var mainCategory in mainCategories)
            {
                mainCategoriesVM.Add(new MainCategoriesVM
                {
                    MainCategoriesID = mainCategory.MainCategoriesID,
                    Main_Category_Name = mainCategory.Main_Category_Name,
                });
            }

            return View(mainCategoriesVM);
        }
        public ActionResult GetSubCategories(int MainCategoryId)
        {


            var Category = _categoriesService.GetCategoryById(MainCategoryId);
            //var mainCategoriesVM = _mapper.Map<List<CategoriesVM>>(Category);
            List<CategoriesVM> mainCategoriesVM = new List<CategoriesVM>();
            foreach (var category in Category)
            {
                mainCategoriesVM.Add(new CategoriesVM
                {
                    CategoriesID = category.CategoriesID,
                    Category_Name = category.Category_Name,
                    MainCategoriesID = category.MainCategoriesID,
                });
            }

            return View(mainCategoriesVM);
        }

        public ActionResult GetProductDetail()

        {
            var productDetail = _productsService.GetProductById(1001);
            List<ProductAttributeDetailVM> productDetailVM = new List<ProductAttributeDetailVM>();
            foreach (var product in productDetail)
            {
                productDetailVM.Add(new ProductAttributeDetailVM
                {
                    ProductsID = product.ProductsID,
                    Product_Name = product.Product_Name,
                    Description = product.Description,
                    CategoriesID = product.CategoriesID,
                    AttributesID = product.AttributesID,
                    Attribute_Name = product.Attribute_Name,
                    Attribute_Value = product.Attribute_Value,

                });
            }
            return View(productDetailVM);

        }
        public ActionResult GetProductsById()

        {
            int productID = 1001;
            var products = _productsService.GetProductById(productID);
            var productsVM = _mapper.Map<List<ProductsVM>>(products);
            return View(productsVM);
        }

        public ActionResult ProductDetail(int ProductId)
        {
            var product = _productsService.GetProductById(ProductId);
            var productVM = _mapper.Map<ProductsVM>(product);
            return View(productVM);
        }




        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}