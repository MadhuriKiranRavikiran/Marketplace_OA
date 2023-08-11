using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceLayer;
using ServiceLayer.Interfaces;
using Marketplace_OA.Models;
using AutoMapper;
using ServiceLayer.Models;
using DomainLayer.Interfaces;
using DomainLayer.Models;
using WebGrease;
using System.Web.Script.Serialization;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Marketplace_OA.Controllers
{
    public class ProductController : Controller
    {

        //code for category
        public IMainCategoriesService _mainCategoriesService;
        public ICategoriesService _categoriesService;
        // code for product details and attributes
        public IProductGetAttributeService _productsService;


        //code for product attributes
        public IProductAttributesService ProductAttributesService;

        //code for attributes table
        public IAttributesService AttributesService;
        private Mapper mapper;

        public ProductController()
        {
            ProductAttributesService = new ProductAttributesService();

            AttributesService = new AttributesService();

            _mainCategoriesService = new MCService();
            _categoriesService = new MCService();
            _productsService = new MCService();


            //using automapper 
            var config = new MapperConfiguration(cfg =>
            {
                // Configuring Map
                cfg.CreateMap<Product_AttributesDTO, ProductAttributesVM>();
                cfg.CreateMap<AttributesDTO, AttributesVM>();

                cfg.CreateMap<ProductAttributeDetailDTO, ProductAttributeDetailVM>();

                cfg.CreateMap<ProductsDTO, ProductsVM>();
                cfg.CreateMap<MainCategoriesDTO, MainCategoriesVM>();
                cfg.CreateMap<CategoriesDTO, CategoriesVM>();
                // Any Other Mapping Configuration ....
            });
            // Create an Instance of Mapper and return that Instance
            mapper = new Mapper(config);
        }

        public ActionResult ProductDetail(string mainCategory, string subCategory, int subCategoryId, int id)
        {
            int ProductID = id;
            var productAttribute = mapper.Map<List<ProductAttributesVM>>(ProductAttributesService.GetProductAttributes(ProductID));

            //try DTO VM
            var productDetailVM = mapper.Map<List<ProductAttributeDetailVM>>(_productsService.GetProductById(ProductID));

            ViewBag.mainCategory = mainCategory;
            ViewBag.subCategory = subCategory;
            ViewBag.subCategoryId = subCategoryId;
            ViewBag.ProductDetail = productDetailVM;
            ViewBag.ProductAttributes = productAttribute;
            return View();

        }

        public ActionResult ProductCompare(string ids)
        {
            var productIds = ids.Split(',').Select(int.Parse).ToList();
            ViewBag.ProductIds = productIds;
            return View();
        }


        // GET: SearchPage
        public ActionResult Search()
        {
            return View();
        }

        // Method called from Search View to get Main category
        public JsonResult GetMainCategories()
        {

            var mainCategoriesVM = mapper.Map<List<MainCategoriesVM>>(_mainCategoriesService.GetAllMainCategories());
            return Json(mainCategoriesVM, JsonRequestBehavior.AllowGet);
        }

        // Method called from Search View to get Subcategory
        public JsonResult GetSubCategories(int MainCategoryId)
        {

            var CategoriesVM = mapper.Map<List<CategoriesVM>>(_categoriesService.GetCategoryById(MainCategoryId));
            return Json(CategoriesVM, JsonRequestBehavior.AllowGet);
        }

        // show product list page based on subcategory
        [HttpPost]
        public ActionResult Search(string mainCategory, string subCategory, int subCategoryId)
        {

            var maincategory = mainCategory;
            var subcategory = subCategory;
            var subcategoryid = subCategoryId;
            // Redirect to the ProductList action to display the results
            return RedirectToAction("ProductList", new { mainCategory = maincategory, subCategory = subcategory, subCategoryId = subcategoryid });
        }

        public ActionResult ProductList(string mainCategory, string subCategory, int subCategoryId)
        {
            // input: string mainCategory, string subCategory, int subCategoryId
            //string mainCategory = "Mechanical";
            //string subCategory = "Car Battery";
            //int subCategoryId = 1;

            int CategoryId = subCategoryId;


            var productsVM = mapper.Map<List<ProductsVM>>(_productsService.GetProductsByCategory(CategoryId));


            //get product details
            List<ProductAttributeDetailVM> productDetailVM = new List<ProductAttributeDetailVM>();
            foreach (var item in productsVM)
            {   //get product id
                var product_id = item.ProductsID;
                var productDetail = _productsService.GetProductById(product_id);

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
            }

            List<AttributesVM> AttributeByCategoryId = mapper.Map<List<AttributesVM>>(AttributesService.GetAttribute(CategoryId));


            ViewBag.mainCategory = mainCategory;
            ViewBag.subCategory = subCategory;
            ViewBag.subCategoryId = subCategoryId;

            ViewBag.productsVM = productsVM;
            ViewBag.productDetailVM = productDetailVM;
            ViewBag.filterAttribute = AttributeByCategoryId;

            return View();
        }

        // AJAX Product filter method
        public ActionResult HandleFilter()
        {
            var json = new StreamReader(Request.InputStream).ReadToEnd();
            var serializer = new JavaScriptSerializer();
            var filterModel = serializer.Deserialize<FilteredViewModel>(json);


            List<FilterCriteria> filter = new List<FilterCriteria>();

            var tilteredAttribute = filterModel.Attributes.ToList();
            var filterNeededCategoryId = filterModel.Attributes.First().CategoriesID;

            foreach (var attribute in tilteredAttribute)
            {
                filter.Add(new FilterCriteria
                {
                    AttributeId = attribute.AttributeId,
                    MinValue = attribute.SelectedMinValue,
                    MaxValue = attribute.SelectedMaxValue
                });
            }

            Filters filters = new Filters();
            var table = filters.GetFilteredProducts(filterNeededCategoryId, filter);


            var mainCategory = filterModel.MainCategory;
            var subCategory = filterModel.SubCategory;



            //int CategoryId = subCategoryId;
            int CategoryId = filterModel.Attributes.First().CategoriesID;

            var productsVM = mapper.Map<List<ProductsVM>>(_productsService.GetProductsByCategory(CategoryId));


            // by table know uniqe product id
            var uniqueProductIds = table.Select(x => x.ProductsID).Distinct().ToList();

            // get products where productid in uniqueProductIds
            var filteredProductsVM = productsVM.Where(p => uniqueProductIds.Contains(p.ProductsID)).ToList();

            //map domain ProductAttributeDetail to ProductAttributeDetailVM
            List<ProductAttributeDetailVM> MappedProductDetailVM = new List<ProductAttributeDetailVM>();
            foreach (var product in table)
            {
                MappedProductDetailVM.Add(new ProductAttributeDetailVM
                {
                    ProductsID = product.ProductsID,
                    Product_Name = product.Product_Name,
                    Description = product.Description,
                    CategoriesID = product.CategoriesID,
                    AttributesID = product.AttributesID,
                    Attribute_Name = product.Attribute_Name,
                    Attribute_Value = product.Attribute_Value,
                    Image_URL = product.Image_URL
                });
            }

            List<AttributesVM> AttributeByCategoryId = mapper.Map<List<AttributesVM>>(AttributesService.GetAttribute(CategoryId));

            ViewBag.mainCategory = mainCategory;
            ViewBag.subCategory = subCategory;
            ViewBag.subCategoryId = CategoryId;
            ViewBag.productsVM = filteredProductsVM;
            ViewBag.productDetailVM = MappedProductDetailVM;
            ViewBag.filterAttribute = AttributeByCategoryId;

            //return Json(filterModel);
            //return Content("Test response from HandleFilter");
            //return Json(FilterAttributeModel, JsonRequestBehavior.AllowGet);
            return PartialView("_FilteredPartialProductList");

        }

        // Handle product list filter clear button
        [HttpPost]
        public ActionResult HandleClear(string mainCategory, string subCategory, int subCategoryId)
        {


            int CategoryId = subCategoryId;

            var productsVM = mapper.Map<List<ProductsVM>>(_productsService.GetProductsByCategory(CategoryId));


            //get product details
            List<ProductAttributeDetailVM> productDetailVM = new List<ProductAttributeDetailVM>();
            foreach (var item in productsVM)
            {   //get product id
                var product_id = item.ProductsID;
                var productDetail = _productsService.GetProductById(product_id);

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
            }


            List<AttributesVM> AttributeByCategoryId = mapper.Map<List<AttributesVM>>(AttributesService.GetAttribute(CategoryId));


            ViewBag.mainCategory = mainCategory;
            ViewBag.subCategory = subCategory;
            ViewBag.subCategoryId = subCategoryId;

            ViewBag.productsVM = productsVM;
            ViewBag.productDetailVM = productDetailVM;
            ViewBag.filterAttribute = AttributeByCategoryId;

            return PartialView("_FilteredPartialProductList");

            // Return a result, such as a PartialView or JSON
        }

        public ActionResult ProductListTest()
        {
            // input: string mainCategory, string subCategory, int subCategoryId
            string mainCategory = "Mechanical";
            string subCategory = "Car Battery";
            int subCategoryId = 1;

            int CategoryId = subCategoryId;
            //var products = _productsService.GetProductsByCategory(CategoryId);
            //List<ProductsVM> productsVM = new List<ProductsVM>();
            //foreach (var product in products)
            //{
            //    productsVM.Add(new ProductsVM
            //    {
            //        ProductsID = product.ProductsID,
            //        Product_Name = product.Product_Name,
            //        Description = product.Description,
            //        CategoriesID = product.CategoriesID,
            //        Image_URL = product.Image_URL,
            //    });
            //}

            //try DTO VM

            var productsVM = mapper.Map<List<ProductsVM>>(_productsService.GetProductsByCategory(CategoryId));


            //get product details
            List<ProductAttributeDetailVM> productDetailVM = new List<ProductAttributeDetailVM>();
            foreach (var item in productsVM)
            {   //get product id
                var product_id = item.ProductsID;
                var productDetail = _productsService.GetProductById(product_id);

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
            }

            // build FilterView object for current subcategory
            int firstProductID = productsVM.First().ProductsID;
            List<FilterView> filterAttribute = new List<FilterView>();
            foreach (var item in productDetailVM.Where(a => a.ProductsID == firstProductID))
            {
                filterAttribute.Add(new FilterView
                {
                    AttributesID = item.AttributesID,
                    Attribute_Name = item.Attribute_Name,
                    Attribute_Max = 100,
                    Attribute_Min = 10
                });
            }

            ViewBag.mainCategory = mainCategory;
            ViewBag.subCategory = subCategory;
            ViewBag.subCategoryId = subCategoryId;
            ViewBag.productsVM = productsVM;
            ViewBag.productDetailVM = productDetailVM;
            ViewBag.filterAttribute = filterAttribute;
            return View();
        }

        [HttpPost]
        public ActionResult HandleFilterTest()
        {


            FilteredViewModel model = new FilteredViewModel();

            foreach (var key in Request.Form.AllKeys)
            {
                // Split the key to extract information
                var parts = key.Split('.');
                if (parts.Length == 3 && parts[0] == "Attributes")
                {
                    int index;
                    if (int.TryParse(parts[1].Replace("[", "").Replace("]", ""), out index))
                    {
                        if (model.Attributes.Count <= index)
                        {
                            model.Attributes.Add(new FilteredViewModel.AttributeFilter());
                        }

                        var value = Request.Form[key];
                        switch (parts[2])
                        {
                            case "AttributeId":
                                model.Attributes[index].AttributeId = int.Parse(value);
                                break;
                            case "SelectedMaxValue":
                                model.Attributes[index].SelectedMaxValue = int.Parse(value);
                                break;
                            case "SelectedMinValue":
                                model.Attributes[index].SelectedMinValue = int.Parse(value);
                                break;
                            case "CategoriesID":
                                model.Attributes[index].CategoriesID = int.Parse(value);
                                break;
                        }
                    }
                }
            }

            return Json(model);
        }



    }
}