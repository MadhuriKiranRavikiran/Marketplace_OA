using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketplace_OA.Controllers
{
    public class ProductController : Controller
    {
        // GET: SearchPage
        public ActionResult Search()
        {
            return View();
        }

        // Method called from Search View to get Main category
        public JsonResult GetMainCategories()
        {
            // Simulated main categories fetched from a database
            var mainCategories = new List<string> { "Mechanical", "Electrical", "Stationery", "Furniture" };

            return Json(mainCategories, JsonRequestBehavior.AllowGet);
        }

        // Method called from Search View to get Subcategory
        public JsonResult GetSubCategories(string mainCategoryId)
        {
            // Simulated subcategories based on the main category
            var subCategoriesData = new Dictionary<string, List<string>>
            {
                { "Mechanical", new List<string> { "Car Battery", "Air Conditioner" } },
                { "Electrical", new List<string> { "Desk Lamp", "Electric Drill" } },
                { "Stationery", new List<string> { "Fountain Pen", "Notebook" } },
                { "Furniture", new List<string> { "Office Chair", "Sofa" } },
            };

            var subCategories = subCategoriesData.ContainsKey(mainCategoryId)
                ? subCategoriesData[mainCategoryId]
                : new List<string>();

            return Json(subCategories, JsonRequestBehavior.AllowGet);
        }

        // show product list page based on subcategory
        [HttpPost]
        public ActionResult Search(string mainCategory, string subCategory)
        {
            // Use mainCategory and searchTerm to search the products in your database

            // hardcode for test
            var maincategory = mainCategory;
            var subcategory = subCategory;
            var products = new Dictionary<string, List<string>>();
            products.Add("maincategory", new List<string> { maincategory });
            products.Add("subcategory", new List<string> { subcategory });
            products.Add("products", new List<string> { "Philips Desk Lamp 60 Watts", "Ikea Desk Lamp 10 Watts" });
            // Store the products in TempData (or another appropriate storage) to pass to the ProductList view
            TempData["Products"] = products;
            // Redirect to the ProductList action to display the results
            return RedirectToAction("ProductList");
        }

        public ActionResult ProductList()
        {
            // Retrieve the products from TempData
            var products = TempData["Products"] as Dictionary<string, List<string>>;

            // Pass the products to the view
            return View(products);
        }
    }
}