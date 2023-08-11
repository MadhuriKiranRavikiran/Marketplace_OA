using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Runtime.Remoting.Contexts;

namespace RepositoryLayer
{
    internal class seed
    {


        public void seedcreate()
        {
            // write your code here to add intial data

            // //*******Copy this "using" part to configuration ****
            //using DomainLayer.Models;
            //using System;
            //using System.Collections.Generic;
            //using System.Data.Entity;
            //using System.Data.Entity.Migrations;
            //using System.Linq;


            // //*****Copy below code to Configuration.cs*****

            //var users = new List<Users>
            //{
            //    new Users {UsersID = 1, User_Name = "test", User_Email = "test@test", Password = "123"}
            //};
            //users.ForEach(s => context.Users.Add(s));
            //context.SaveChanges();


            //var mainCategories = new List<MainCategories>
            //{
            //    new MainCategories { MainCategoriesID = 1, Main_Category_Name = "Mechanical" },
            //    new MainCategories { MainCategoriesID = 2, Main_Category_Name = "Electrical" },
            //    new MainCategories { MainCategoriesID = 3, Main_Category_Name = "Stationery" },
            //    new MainCategories { MainCategoriesID = 4, Main_Category_Name = "Furniture" }
            //};
            //mainCategories.ForEach(s => context.MainCategories.Add(s));
            //context.SaveChanges();

            //var subCategories = new List<Categories>
            //{
            //    new Categories { CategoriesID = 1, Category_Name = "Car Battery", MainCategoriesID = 1 },
            //    new Categories { CategoriesID = 2, Category_Name = "Air Conditioner", MainCategoriesID = 1 },
            //    new Categories { CategoriesID = 3, Category_Name = "Desk Lamp", MainCategoriesID = 2 },
            //    new Categories { CategoriesID = 4, Category_Name = "Electric Drill", MainCategoriesID = 2 },
            //    new Categories { CategoriesID = 5, Category_Name = "Fountain Pen", MainCategoriesID = 3 },
            //    new Categories { CategoriesID = 6, Category_Name = "Spiral Notebook", MainCategoriesID = 3 },
            //    new Categories { CategoriesID = 7, Category_Name = "Office Chair", MainCategoriesID = 4 },
            //    new Categories { CategoriesID = 8, Category_Name = "Sofa", MainCategoriesID = 4 }
            //};
            //subCategories.ForEach(s => context.Categories.Add(s));
            //context.SaveChanges();

            //// Another formate, each category 6 rows
            //var attributes2 = new List<Attributes>
            //{
            //    // Subcategory: Car Battery
            //    new Attributes { AttributesID = 1, Attribute_Name = "Capacity (Ah)", min_value = 0, max_value = 100, Value_Type = "Number", CategoriesID = 1 },
            //    new Attributes { AttributesID = 2, Attribute_Name = "Warranty (Years)", min_value = 0, max_value = 10, Value_Type = "Number", CategoriesID = 1 },
            //    new Attributes { AttributesID = 3, Attribute_Name = "Weight (Kg)", min_value = 10, max_value = 100, Value_Type = "Number", CategoriesID = 1 },
            //    new Attributes { AttributesID = 4, Attribute_Name = "Voltage (V)", min_value = 5, max_value = 50, Value_Type = "Number", CategoriesID = 1 },
            //    new Attributes { AttributesID = 5, Attribute_Name = "Brand", Value_Type = "Text", CategoriesID = 1 },
            //    new Attributes { AttributesID = 6, Attribute_Name = "Type", Value_Type = "Text", CategoriesID = 1 },
            //    //add Model Year
            //    new Attributes { AttributesID = 49, Attribute_Name = "Model Year", min_value = 1000, max_value = 3000, Value_Type = "Text", CategoriesID = 1 },

            //    // Subcategory: Air Conditioner
            //    new Attributes { AttributesID = 7, Attribute_Name = "BTU", min_value = 10000, max_value = 30000, Value_Type = "Number", CategoriesID = 2 },
            //    new Attributes { AttributesID = 8, Attribute_Name = "Energy Efficiency Rating", min_value = 0, max_value = 10, Value_Type = "Number", CategoriesID = 2 },
            //    new Attributes { AttributesID = 9, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 100, Value_Type = "Number", CategoriesID = 2 },
            //    new Attributes { AttributesID = 10, Attribute_Name = "Noise Level (dB)", min_value = 0, max_value = 100, Value_Type = "Number", CategoriesID = 2 },
            //    new Attributes { AttributesID = 11, Attribute_Name = "Brand", Value_Type = "Text", CategoriesID = 2 },
            //    new Attributes { AttributesID = 12, Attribute_Name = "Type", Value_Type = "Text", CategoriesID = 2 },
            //    //add Model Year
            //    new Attributes { AttributesID = 50, Attribute_Name = "Model Year", min_value = 1000, max_value = 3000, Value_Type = "Text", CategoriesID = 2 },

            //// Subcategory: Desk Lamp
            //    new Attributes { AttributesID = 13, Attribute_Name = "Wattage (W)", min_value = 0, max_value = 1000, Value_Type = "Number", CategoriesID = 3 },
            //    new Attributes { AttributesID = 14, Attribute_Name = "Height (cm)", min_value = 0, max_value = 200, Value_Type = "Number", CategoriesID = 3 },
            //    new Attributes { AttributesID = 15, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 100, Value_Type = "Number", CategoriesID = 3 },
            //    new Attributes { AttributesID = 16, Attribute_Name = "Lifespan (Hours)", min_value = 0, max_value = 100000, Value_Type = "Number", CategoriesID = 3 },
            //    new Attributes { AttributesID = 17, Attribute_Name = "Color", Value_Type = "Text", CategoriesID = 3 },
            //    new Attributes { AttributesID = 18, Attribute_Name = "Material", Value_Type = "Text" , CategoriesID = 3},
            //    //add Model Year
            //    new Attributes { AttributesID = 51, Attribute_Name = "Model Year", min_value = 1000, max_value = 3000, Value_Type = "Text", CategoriesID = 3 },

            //    // Subcategory: Electric Drill
            //    new Attributes { AttributesID = 19, Attribute_Name = "Power (W)", min_value = 0, max_value = 1000, Value_Type = "Number", CategoriesID = 4 },
            //    new Attributes { AttributesID = 20, Attribute_Name = "Speed (RPM)", min_value = 0, max_value = 5000, Value_Type = "Number", CategoriesID = 4 },
            //    new Attributes { AttributesID = 21, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 100, Value_Type = "Number", CategoriesID = 4},
            //    new Attributes { AttributesID = 22, Attribute_Name = "Cable Length (M)", min_value = 0, max_value = 50, Value_Type = "Number", CategoriesID = 4},
            //    new Attributes { AttributesID = 23, Attribute_Name = "Color", Value_Type = "Text", CategoriesID = 4 },
            //    new Attributes { AttributesID = 24, Attribute_Name = "Material", Value_Type = "Text", CategoriesID = 4},
            //    //add Model Year
            //    new Attributes { AttributesID = 52, Attribute_Name = "Model Year", min_value = 1000, max_value = 3000, Value_Type = "Text", CategoriesID = 4 },

            //    // Subcategory: Fountain Pen
            //    new Attributes { AttributesID = 25, Attribute_Name = "Length (cm)", min_value = 0, max_value = 50, Value_Type = "Number", CategoriesID = 5 },
            //    new Attributes { AttributesID = 26, Attribute_Name = "Weight (g)", min_value = 0, max_value = 1000, Value_Type = "Number", CategoriesID = 5 },
            //    new Attributes { AttributesID = 27, Attribute_Name = "Diameter (mm)", min_value = 0, max_value = 50, Value_Type = "Number", CategoriesID = 5 },
            //    new Attributes { AttributesID = 28, Attribute_Name = "Warranty (Years)", min_value = 0, max_value = 100, Value_Type = "Number", CategoriesID = 5 },
            //    new Attributes { AttributesID = 29, Attribute_Name = "Color", Value_Type = "Text", CategoriesID = 5 },
            //    new Attributes { AttributesID = 30, Attribute_Name = "Material", Value_Type = "Text", CategoriesID = 5 },
            //    //add Model Year
            //    new Attributes { AttributesID = 53, Attribute_Name = "Model Year", min_value = 1000, max_value = 3000, Value_Type = "Text", CategoriesID = 5 },

            //    // Subcategory: Spiral Notebook
            //    new Attributes { AttributesID = 31, Attribute_Name = "Pages", min_value = 0, max_value = 1000, Value_Type = "Number", CategoriesID = 6 },
            //    new Attributes { AttributesID = 32, Attribute_Name = "Weight (g)", min_value = 0, max_value = 5000, Value_Type = "Number", CategoriesID = 6 },
            //    new Attributes { AttributesID = 33, Attribute_Name = "Width (cm)", min_value = 0, max_value = 50, Value_Type = "Number", CategoriesID = 6 },
            //    new Attributes { AttributesID = 34, Attribute_Name = "Height (cm)", min_value = 0, max_value = 50, Value_Type = "Number", CategoriesID = 6 },
            //    new Attributes { AttributesID = 35, Attribute_Name = "Color", Value_Type = "Text", CategoriesID = 6 },
            //    new Attributes { AttributesID = 36, Attribute_Name = "Material", Value_Type = "Text", CategoriesID = 6 },
            //    //add Model Year
            //    new Attributes { AttributesID = 54, Attribute_Name = "Model Year", min_value = 1000, max_value = 3000, Value_Type = "Text", CategoriesID = 6 },


            //    // Subcategory: Office Chair
            //    new Attributes { AttributesID = 37, Attribute_Name = "Weight Capacity (Kg)", min_value = 0, max_value = 500, Value_Type = "Number", CategoriesID = 7 },
            //    new Attributes { AttributesID = 38, Attribute_Name = "Height (cm)", min_value = 0, max_value = 200, Value_Type = "Number", CategoriesID = 7 },
            //    new Attributes { AttributesID = 39, Attribute_Name = "Width (cm)", min_value = 0, max_value = 200, Value_Type = "Number", CategoriesID = 7 },
            //    new Attributes { AttributesID = 40, Attribute_Name = "Depth (cm)", min_value = 0, max_value = 200, Value_Type = "Number", CategoriesID = 7 },
            //    new Attributes { AttributesID = 41, Attribute_Name = "Color", Value_Type = "Text", CategoriesID = 7 },
            //    new Attributes { AttributesID = 42, Attribute_Name = "Material", Value_Type = "Text", CategoriesID = 7 },
            //    //add Model Year
            //    new Attributes { AttributesID = 55, Attribute_Name = "Model Year", min_value = 1000, max_value = 3000, Value_Type = "Text", CategoriesID = 7 },

            //    // Subcategory: Sofa
            //    new Attributes { AttributesID = 43, Attribute_Name = "Weight Capacity (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number", CategoriesID = 8 },
            //    new Attributes { AttributesID = 44, Attribute_Name = "Width (cm)", min_value = 0, max_value = 500, Value_Type = "Number", CategoriesID = 8 },
            //    new Attributes { AttributesID = 45, Attribute_Name = "Height (cm)", min_value = 0, max_value = 200, Value_Type = "Number", CategoriesID = 8},
            //    new Attributes { AttributesID = 46, Attribute_Name = "Depth (cm)", min_value = 0, max_value = 500, Value_Type = "Number", CategoriesID = 8},
            //    new Attributes { AttributesID = 47, Attribute_Name = "Color", Value_Type = "Text", CategoriesID = 8 },
            //    new Attributes { AttributesID = 48, Attribute_Name = "Material", Value_Type = "Text", CategoriesID = 8 },
            //    //add Model Year
            //    new Attributes { AttributesID = 56, Attribute_Name = "Model Year", min_value = 1000, max_value = 3000, Value_Type = "Text", CategoriesID = 8 },

            //    // Add more attributes for category 1
            //     new Attributes { AttributesID = 57, Attribute_Name = "Cold Cranking Amps (CCA)", min_value = 20, max_value = 60, Value_Type = "Number", CategoriesID = 1 },
            //     new Attributes { AttributesID = 58, Attribute_Name = "Reserve Capacity (RC)", min_value = 10, max_value = 100, Value_Type = "Number", CategoriesID = 1 },

            //};
            //attributes2.ForEach(s => context.Attributes.Add(s));
            //context.SaveChanges();


            //var products = new List<Products>
            //{
            //    new Products { ProductsID = 1, Product_Name = "Exide Car Battery 60 Ah", Description = "Exide Car Battery 60 Ah Description", Image_URL = "image1.png", CategoriesID = 1 },
            //    new Products { ProductsID = 2, Product_Name = "Amaron Car Battery 80 Ah", Description = "Amaron Car Battery 80 Ah Description", Image_URL = "image2.png", CategoriesID = 1 },
            //    new Products { ProductsID = 3, Product_Name = "Daikin Air Conditioner 12000 BTU", Description = "Daikin Air Conditioner 12000 BTU Description", Image_URL = "image3.png", CategoriesID = 2 },
            //    new Products { ProductsID = 4, Product_Name = "Samsung Air Conditioner 18000 BTU", Description = "Samsung Air Conditioner 18000 BTU Description", Image_URL = "image4.png", CategoriesID = 2 },
            //    new Products { ProductsID = 5, Product_Name = "Philips Desk Lamp 60 Watts", Description = "Philips Desk Lamp 60 Watts Description", Image_URL = "image5.png", CategoriesID = 3 },
            //    new Products { ProductsID = 6, Product_Name = "Ikea Desk Lamp 10 Watts", Description = "Ikea Desk Lamp 10 Watts Description", Image_URL = "image6.png", CategoriesID = 3 },
            //    new Products { ProductsID = 7, Product_Name = "Bosch Electric Drill 600 Watts", Description = "Bosch Electric Drill 600 Watts Description", Image_URL = "image7.png", CategoriesID = 4 },
            //    new Products { ProductsID = 8, Product_Name = "Black & Decker Electric Drill 550 Watts", Description = "Black & Decker Electric Drill 550 Watts Description", Image_URL = "image8.png", CategoriesID = 4 },
            //    new Products { ProductsID = 9, Product_Name = "Parker Fountain Pen", Description = "Parker Fountain Pen Description", Image_URL = "image9.png", CategoriesID = 5 },
            //    new Products { ProductsID = 10, Product_Name = "Montblanc Fountain Pen", Description = "Montblanc Fountain Pen Description", Image_URL = "image10.png", CategoriesID = 5 },
            //    new Products { ProductsID = 11, Product_Name = "Moleskine Spiral Notebook 200 Pages", Description = "Moleskine Spiral Notebook 200 Pages Description", Image_URL = "image11.png", CategoriesID = 6 },
            //    new Products { ProductsID = 12, Product_Name = "Oxford Spiral Notebook 100 Pages", Description = "Oxford Spiral Notebook 100 Pages Description", Image_URL = "image12.png", CategoriesID = 6 },
            //    new Products { ProductsID = 13, Product_Name = "Herman Miller Aeron Office Chair", Description = "Herman Miller Aeron Office Chair Description", Image_URL = "image13.png", CategoriesID = 7 },
            //    new Products { ProductsID = 14, Product_Name = "Steelcase Gesture Office Chair", Description = "Steelcase Gesture Office Chair Description", Image_URL = "image14.png", CategoriesID = 7 },
            //    new Products { ProductsID = 15, Product_Name = "Ashley Furniture Leather Sofa", Description = "Ashley Furniture Leather Sofa Description", Image_URL = "image15.png", CategoriesID = 8 },
            //    new Products { ProductsID = 16, Product_Name = "Ikea Ektorp Fabric Sofa", Description = "Ikea Ektorp Fabric Sofa Description", Image_URL = "image16.png", CategoriesID = 8 },

            //    // new more product for subcategory 1
            //    new Products { ProductsID = 17, Product_Name = "Optima Car Battery 40 Ah", Description = "Optima Car Batter 40 Ah Description", Image_URL = "image17.png", CategoriesID = 1 },
            //    new Products { ProductsID = 18, Product_Name = "Bosch Car Battery 30 Ah", Description = "Bosch Car Battery 30 Ah Description", Image_URL = "image18.png", CategoriesID = 1 },
            //    new Products { ProductsID = 19, Product_Name = "Varta Car Battery 50 Ah", Description = "Varta Car Battery 50 Ah Description", Image_URL = "image19.png", CategoriesID = 1 },
            //    new Products { ProductsID = 20, Product_Name = "DieHard Car Battery 90 Ah", Description = "DieHard Car Battery 90 Ah Description", Image_URL = "image20.png", CategoriesID = 1 }
            //};
            //products.ForEach(s => context.Products.Add(s));
            //context.SaveChanges();

            //// only for first main category and its two subcategory products
            //var attributeValues = new List<Attribute_Values>
            //{
            //    // For Exide Car Battery
            //    new Attribute_Values { Attribute_ValuesID = 1, AttributesID = 1, Attribute_Value = "60" }, // Capacity (Ah)
            //    new Attribute_Values { Attribute_ValuesID = 2, AttributesID = 2, Attribute_Value = "3" }, // Warranty (Years)
            //    new Attribute_Values { Attribute_ValuesID = 3, AttributesID = 3, Attribute_Value = "15.2" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 4, AttributesID = 4, Attribute_Value = "12" }, // Voltage (V)
            //    new Attribute_Values { Attribute_ValuesID = 5, AttributesID = 5, Attribute_Value = "Exide" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 6, AttributesID = 6, Attribute_Value = "Wet Battery" }, // Type
            //    //add new attribute
            //    new Attribute_Values { Attribute_ValuesID = 25, AttributesID = 49, Attribute_Value = "2000" }, // Model Year
            //    new Attribute_Values { Attribute_ValuesID = 26, AttributesID = 57, Attribute_Value = "50" }, // Cold Cranking Amps (CCA)
            //    new Attribute_Values { Attribute_ValuesID = 27, AttributesID = 58, Attribute_Value = "90" }, // Reserve Capacity (RC)

            //    // For Amaron Car Battery
            //    new Attribute_Values { Attribute_ValuesID = 7, AttributesID = 1, Attribute_Value = "80" }, // Capacity (Ah)
            //    new Attribute_Values { Attribute_ValuesID = 8, AttributesID = 2, Attribute_Value = "7" }, // Warranty (Years)
            //    new Attribute_Values { Attribute_ValuesID = 9, AttributesID = 3, Attribute_Value = "18.3" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 10, AttributesID = 4, Attribute_Value = "42" }, // Voltage (V)
            //    new Attribute_Values { Attribute_ValuesID = 11, AttributesID = 5, Attribute_Value = "Amaron" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 12, AttributesID = 6, Attribute_Value = "Wet Battery" }, // Type
            //    //add new attribute
            //    new Attribute_Values { Attribute_ValuesID = 28, AttributesID = 49, Attribute_Value = "2002" }, // Model Year
            //    new Attribute_Values { Attribute_ValuesID = 29, AttributesID = 57, Attribute_Value = "30" }, // Cold Cranking Amps (CCA)
            //    new Attribute_Values { Attribute_ValuesID = 30, AttributesID = 58, Attribute_Value = "40" }, // Reserve Capacity (RC)

            //    // For Optima Car Battery
            //    new Attribute_Values { Attribute_ValuesID = 33, AttributesID = 1, Attribute_Value = "40" }, // Capacity (Ah)
            //    new Attribute_Values { Attribute_ValuesID = 34, AttributesID = 2, Attribute_Value = "2" }, // Warranty (Years)
            //    new Attribute_Values { Attribute_ValuesID = 35, AttributesID = 3, Attribute_Value = "45.2" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 36, AttributesID = 4, Attribute_Value = "15" }, // Voltage (V)
            //    new Attribute_Values { Attribute_ValuesID = 37, AttributesID = 5, Attribute_Value = "Optima" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 38, AttributesID = 6, Attribute_Value = "Dry Battery" }, // Type
            //    //add new attribute
            //    new Attribute_Values { Attribute_ValuesID = 39, AttributesID = 49, Attribute_Value = "2006" }, // Model Year
            //    new Attribute_Values { Attribute_ValuesID = 40, AttributesID = 57, Attribute_Value = "40" }, // Cold Cranking Amps (CCA)
            //    new Attribute_Values { Attribute_ValuesID = 41, AttributesID = 58, Attribute_Value = "30" }, // Reserve Capacity (RC)

            //    // For Bosch Car Battery
            //    new Attribute_Values { Attribute_ValuesID = 42, AttributesID = 1, Attribute_Value = "30" }, // Capacity (Ah)
            //    new Attribute_Values { Attribute_ValuesID = 43, AttributesID = 2, Attribute_Value = "1" }, // Warranty (Years)
            //    new Attribute_Values { Attribute_ValuesID = 44, AttributesID = 3, Attribute_Value = "35.2" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 45, AttributesID = 4, Attribute_Value = "12" }, // Voltage (V)
            //    new Attribute_Values { Attribute_ValuesID = 46, AttributesID = 5, Attribute_Value = "Bosch" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 47, AttributesID = 6, Attribute_Value = "Wet Battery" }, // Type
            //    //add new attribute
            //    new Attribute_Values { Attribute_ValuesID = 48, AttributesID = 49, Attribute_Value = "2001" }, // Model Year
            //    new Attribute_Values { Attribute_ValuesID = 49, AttributesID = 57, Attribute_Value = "22" }, // Cold Cranking Amps (CCA)
            //    new Attribute_Values { Attribute_ValuesID = 50, AttributesID = 58, Attribute_Value = "40" }, // Reserve Capacity (RC)

            //    // For Varta Car Battery
            //     new Attribute_Values { Attribute_ValuesID = 51, AttributesID = 1, Attribute_Value = "50" }, // Capacity (Ah)
            //    new Attribute_Values { Attribute_ValuesID = 52, AttributesID = 2, Attribute_Value = "5" }, // Warranty (Years)
            //    new Attribute_Values { Attribute_ValuesID = 53, AttributesID = 3, Attribute_Value = "55.2" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 54, AttributesID = 4, Attribute_Value = "32" }, // Voltage (V)
            //    new Attribute_Values { Attribute_ValuesID = 55, AttributesID = 5, Attribute_Value = "Varta" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 56, AttributesID = 6, Attribute_Value = "Dry Battery" }, // Type
            //    //add new attribute
            //    new Attribute_Values { Attribute_ValuesID = 57, AttributesID = 49, Attribute_Value = "2012" }, // Model Year
            //    new Attribute_Values { Attribute_ValuesID = 58, AttributesID = 57, Attribute_Value = "45" }, // Cold Cranking Amps (CCA)
            //    new Attribute_Values { Attribute_ValuesID = 59, AttributesID = 58, Attribute_Value = "80" }, // Reserve Capacity (RC)

            //    // For DieHard Car Battery
            //     new Attribute_Values { Attribute_ValuesID = 60, AttributesID = 1, Attribute_Value = "90" }, // Capacity (Ah)
            //    new Attribute_Values { Attribute_ValuesID = 61, AttributesID = 2, Attribute_Value = "8" }, // Warranty (Years)
            //    new Attribute_Values { Attribute_ValuesID = 62, AttributesID = 3, Attribute_Value = "75.2" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 63, AttributesID = 4, Attribute_Value = "42" }, // Voltage (V)
            //    new Attribute_Values { Attribute_ValuesID = 64, AttributesID = 5, Attribute_Value = "DieHard" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 65, AttributesID = 6, Attribute_Value = "Wet Battery" }, // Type
            //    //add new attribute
            //    new Attribute_Values { Attribute_ValuesID = 66, AttributesID = 49, Attribute_Value = "2016" }, // Model Year
            //    new Attribute_Values { Attribute_ValuesID = 67, AttributesID = 57, Attribute_Value = "58" }, // Cold Cranking Amps (CCA)
            //    new Attribute_Values { Attribute_ValuesID = 68, AttributesID = 58, Attribute_Value = "90" }, // Reserve Capacity (RC)


            //    // For Daikin Air Conditioner
            //    new Attribute_Values { Attribute_ValuesID = 13, AttributesID = 7, Attribute_Value = "12000" }, // BTU
            //    new Attribute_Values { Attribute_ValuesID = 14, AttributesID = 8, Attribute_Value = "9.5" }, // Energy Efficiency Rating
            //    new Attribute_Values { Attribute_ValuesID = 15, AttributesID = 9, Attribute_Value = "30" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 16, AttributesID = 10, Attribute_Value = "55" }, // Noise Level (dB)
            //    new Attribute_Values { Attribute_ValuesID = 17, AttributesID = 11, Attribute_Value = "Daikin" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 18, AttributesID = 12, Attribute_Value = "Split System" }, // Type
            //    //add new attribute
            //    new Attribute_Values { Attribute_ValuesID = 31, AttributesID = 50, Attribute_Value = "2006" }, // Model Year

            //    // For Samsung Air Conditioner
            //    new Attribute_Values { Attribute_ValuesID = 19, AttributesID = 7, Attribute_Value = "18000" }, // BTU
            //    new Attribute_Values { Attribute_ValuesID = 20, AttributesID = 8, Attribute_Value = "2" }, // Energy Efficiency Rating
            //    new Attribute_Values { Attribute_ValuesID = 21, AttributesID = 9, Attribute_Value = "85" }, // Weight (Kg)
            //    new Attribute_Values { Attribute_ValuesID = 22, AttributesID = 10, Attribute_Value = "97" }, // Noise Level (dB)
            //    new Attribute_Values { Attribute_ValuesID = 23, AttributesID = 11, Attribute_Value = "Samsung" }, // Brand
            //    new Attribute_Values { Attribute_ValuesID = 24, AttributesID = 12, Attribute_Value = "Split System" }, // Type
            //    //add new attribute
            //    new Attribute_Values { Attribute_ValuesID = 32, AttributesID = 50, Attribute_Value = "2010" }, // Model Year
            //};
            //attributeValues.ForEach(s => context.Attribute_Values.Add(s));
            //context.SaveChanges();


            //// only for first main category and its two subcategory products
            //var productAttributes = new List<Product_Attributes>
            //{
            //    // For Exide Car Battery
            //    new Product_Attributes { ProductsID = 1, AttributesID = 1, Discrete_Attribute_Value_ID = 1, Min_Continuous_Attribute_Value = 60, Max_Continuous_Attribute_Value = 60 }, // Capacity (Ah)
            //    new Product_Attributes { ProductsID = 1, AttributesID = 2, Discrete_Attribute_Value_ID = 2, Min_Continuous_Attribute_Value = 3, Max_Continuous_Attribute_Value = 3 }, // Warranty (Years)
            //    new Product_Attributes { ProductsID = 1, AttributesID = 3, Discrete_Attribute_Value_ID = 3, Min_Continuous_Attribute_Value = 15.2, Max_Continuous_Attribute_Value = 15.2 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 1, AttributesID = 4, Discrete_Attribute_Value_ID = 4, Min_Continuous_Attribute_Value = 12, Max_Continuous_Attribute_Value = 12 }, // Voltage (V)
            //    new Product_Attributes { ProductsID = 1, AttributesID = 5, Discrete_Attribute_Value_ID = 5 }, // Brand
            //    new Product_Attributes { ProductsID = 1, AttributesID = 6, Discrete_Attribute_Value_ID = 6 }, // Type
            //    //add new product attributes
            //    new Product_Attributes { ProductsID = 1, AttributesID = 49, Discrete_Attribute_Value_ID = 25, Min_Continuous_Attribute_Value = 2000, Max_Continuous_Attribute_Value = 2000 }, // Model Year
            //    new Product_Attributes { ProductsID = 1, AttributesID = 57, Discrete_Attribute_Value_ID = 26, Min_Continuous_Attribute_Value = 50, Max_Continuous_Attribute_Value = 50 }, // Cold Cranking Amps (CCA)
            //    new Product_Attributes { ProductsID = 1, AttributesID = 58, Discrete_Attribute_Value_ID = 27, Min_Continuous_Attribute_Value = 90, Max_Continuous_Attribute_Value = 90 }, // Reserve Capacity (RC)

            //    // For Amaron Car Battery
            //    new Product_Attributes { ProductsID = 2, AttributesID = 1, Discrete_Attribute_Value_ID = 7, Min_Continuous_Attribute_Value = 80, Max_Continuous_Attribute_Value = 80 }, // Capacity (Ah)
            //    new Product_Attributes { ProductsID = 2, AttributesID = 2, Discrete_Attribute_Value_ID = 8, Min_Continuous_Attribute_Value = 4, Max_Continuous_Attribute_Value = 4 }, // Warranty (Years)
            //    new Product_Attributes { ProductsID = 2, AttributesID = 3, Discrete_Attribute_Value_ID = 9, Min_Continuous_Attribute_Value = 18.3, Max_Continuous_Attribute_Value = 18.3 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 2, AttributesID = 4, Discrete_Attribute_Value_ID = 10, Min_Continuous_Attribute_Value = 42, Max_Continuous_Attribute_Value = 42 }, // Voltage (V)
            //    new Product_Attributes { ProductsID = 2, AttributesID = 5, Discrete_Attribute_Value_ID = 11 }, // Brand
            //    new Product_Attributes { ProductsID = 2, AttributesID = 6, Discrete_Attribute_Value_ID = 12 }, // Type
            //    //add new product attributes
            //    new Product_Attributes { ProductsID = 2, AttributesID = 49, Discrete_Attribute_Value_ID = 28, Min_Continuous_Attribute_Value = 2002, Max_Continuous_Attribute_Value = 2002 }, // Model Year
            //    new Product_Attributes { ProductsID = 2, AttributesID = 57, Discrete_Attribute_Value_ID = 29, Min_Continuous_Attribute_Value = 30, Max_Continuous_Attribute_Value = 30 }, // Cold Cranking Amps (CCA)
            //    new Product_Attributes { ProductsID = 2, AttributesID = 58, Discrete_Attribute_Value_ID = 30, Min_Continuous_Attribute_Value = 40, Max_Continuous_Attribute_Value = 40 }, // Reserve Capacity (RC)

            //    // For Optima Car Battery 40 Ah
            //    new Product_Attributes { ProductsID = 17, AttributesID = 1, Discrete_Attribute_Value_ID = 33, Min_Continuous_Attribute_Value = 40, Max_Continuous_Attribute_Value = 40 }, // Capacity (Ah)
            //    new Product_Attributes { ProductsID = 17, AttributesID = 2, Discrete_Attribute_Value_ID = 34, Min_Continuous_Attribute_Value = 2, Max_Continuous_Attribute_Value = 2 }, // Warranty (Years)
            //    new Product_Attributes { ProductsID = 17, AttributesID = 3, Discrete_Attribute_Value_ID = 35, Min_Continuous_Attribute_Value = 45.2, Max_Continuous_Attribute_Value = 45.2 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 17, AttributesID = 4, Discrete_Attribute_Value_ID = 36, Min_Continuous_Attribute_Value = 15, Max_Continuous_Attribute_Value = 15 }, // Voltage (V)
            //    new Product_Attributes { ProductsID = 17, AttributesID = 5, Discrete_Attribute_Value_ID = 37 }, // Brand
            //    new Product_Attributes { ProductsID = 17, AttributesID = 6, Discrete_Attribute_Value_ID = 38 }, // Type
            //    //add new product attributes
            //    new Product_Attributes { ProductsID = 17, AttributesID = 49, Discrete_Attribute_Value_ID = 39, Min_Continuous_Attribute_Value = 2006, Max_Continuous_Attribute_Value = 2006 }, // Model Year
            //    new Product_Attributes { ProductsID = 17, AttributesID = 57, Discrete_Attribute_Value_ID = 40, Min_Continuous_Attribute_Value = 40, Max_Continuous_Attribute_Value = 40 }, // Cold Cranking Amps (CCA)
            //    new Product_Attributes { ProductsID = 17, AttributesID = 58, Discrete_Attribute_Value_ID = 41, Min_Continuous_Attribute_Value = 30, Max_Continuous_Attribute_Value = 30 }, // Reserve Capacity (RC)

            //    // For Bosch Car Battery 30 Ah
            //    new Product_Attributes { ProductsID = 18, AttributesID = 1, Discrete_Attribute_Value_ID = 42, Min_Continuous_Attribute_Value = 30, Max_Continuous_Attribute_Value = 30 }, // Capacity (Ah)
            //    new Product_Attributes { ProductsID = 18, AttributesID = 2, Discrete_Attribute_Value_ID = 43, Min_Continuous_Attribute_Value = 1, Max_Continuous_Attribute_Value = 1 }, // Warranty (Years)
            //    new Product_Attributes { ProductsID = 18, AttributesID = 3, Discrete_Attribute_Value_ID = 44, Min_Continuous_Attribute_Value = 35.2, Max_Continuous_Attribute_Value = 35.2 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 18, AttributesID = 4, Discrete_Attribute_Value_ID = 45, Min_Continuous_Attribute_Value = 12, Max_Continuous_Attribute_Value = 12 }, // Voltage (V)
            //    new Product_Attributes { ProductsID = 18, AttributesID = 5, Discrete_Attribute_Value_ID = 46 }, // Brand
            //    new Product_Attributes { ProductsID = 18, AttributesID = 6, Discrete_Attribute_Value_ID = 47 }, // Type
            //    //add new product attributes
            //    new Product_Attributes { ProductsID = 18, AttributesID = 49, Discrete_Attribute_Value_ID = 48, Min_Continuous_Attribute_Value = 2001, Max_Continuous_Attribute_Value = 2001 }, // Model Year
            //    new Product_Attributes { ProductsID = 18, AttributesID = 57, Discrete_Attribute_Value_ID = 49, Min_Continuous_Attribute_Value = 22, Max_Continuous_Attribute_Value = 22 }, // Cold Cranking Amps (CCA)
            //    new Product_Attributes { ProductsID = 18, AttributesID = 58, Discrete_Attribute_Value_ID = 50, Min_Continuous_Attribute_Value = 40, Max_Continuous_Attribute_Value = 40 }, // Reserve Capacity (RC)

            //    // For Varta Car Battery 50 Ah
            //    new Product_Attributes { ProductsID = 19, AttributesID = 1, Discrete_Attribute_Value_ID = 51, Min_Continuous_Attribute_Value = 50, Max_Continuous_Attribute_Value = 50 }, // Capacity (Ah)
            //    new Product_Attributes { ProductsID = 19, AttributesID = 2, Discrete_Attribute_Value_ID = 52, Min_Continuous_Attribute_Value = 5, Max_Continuous_Attribute_Value = 5 }, // Warranty (Years)
            //    new Product_Attributes { ProductsID = 19, AttributesID = 3, Discrete_Attribute_Value_ID = 53, Min_Continuous_Attribute_Value = 55.2, Max_Continuous_Attribute_Value = 55.2 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 19, AttributesID = 4, Discrete_Attribute_Value_ID = 54, Min_Continuous_Attribute_Value = 32, Max_Continuous_Attribute_Value = 32 }, // Voltage (V)
            //    new Product_Attributes { ProductsID = 19, AttributesID = 5, Discrete_Attribute_Value_ID = 55 }, // Brand
            //    new Product_Attributes { ProductsID = 19, AttributesID = 6, Discrete_Attribute_Value_ID = 56 }, // Type
            //    //add new product attributes
            //    new Product_Attributes { ProductsID = 19, AttributesID = 49, Discrete_Attribute_Value_ID = 57, Min_Continuous_Attribute_Value = 2012, Max_Continuous_Attribute_Value = 2012 }, // Model Year
            //    new Product_Attributes { ProductsID = 19, AttributesID = 57, Discrete_Attribute_Value_ID = 58, Min_Continuous_Attribute_Value = 45, Max_Continuous_Attribute_Value = 45 }, // Cold Cranking Amps (CCA)
            //    new Product_Attributes { ProductsID = 19, AttributesID = 58, Discrete_Attribute_Value_ID = 59, Min_Continuous_Attribute_Value = 80, Max_Continuous_Attribute_Value = 80 }, // Reserve Capacity (RC)

            //    // For DieHard Car Battery 90 Ah
            //    new Product_Attributes { ProductsID = 20, AttributesID = 1, Discrete_Attribute_Value_ID = 60, Min_Continuous_Attribute_Value = 90, Max_Continuous_Attribute_Value = 90 }, // Capacity (Ah)
            //    new Product_Attributes { ProductsID = 20, AttributesID = 2, Discrete_Attribute_Value_ID = 61, Min_Continuous_Attribute_Value = 8, Max_Continuous_Attribute_Value = 8 }, // Warranty (Years)
            //    new Product_Attributes { ProductsID = 20, AttributesID = 3, Discrete_Attribute_Value_ID = 62, Min_Continuous_Attribute_Value = 75.2, Max_Continuous_Attribute_Value = 75.2 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 20, AttributesID = 4, Discrete_Attribute_Value_ID = 63, Min_Continuous_Attribute_Value = 42, Max_Continuous_Attribute_Value = 42 }, // Voltage (V)
            //    new Product_Attributes { ProductsID = 20, AttributesID = 5, Discrete_Attribute_Value_ID = 64 }, // Brand
            //    new Product_Attributes { ProductsID = 20, AttributesID = 6, Discrete_Attribute_Value_ID = 65 }, // Type
            //    //add new product attributes
            //    new Product_Attributes { ProductsID = 20, AttributesID = 49, Discrete_Attribute_Value_ID = 66, Min_Continuous_Attribute_Value = 2016, Max_Continuous_Attribute_Value = 2016 }, // Model Year
            //    new Product_Attributes { ProductsID = 20, AttributesID = 57, Discrete_Attribute_Value_ID = 67, Min_Continuous_Attribute_Value = 58, Max_Continuous_Attribute_Value = 58 }, // Cold Cranking Amps (CCA)
            //    new Product_Attributes { ProductsID = 20, AttributesID = 58, Discrete_Attribute_Value_ID = 68, Min_Continuous_Attribute_Value = 90, Max_Continuous_Attribute_Value = 90 }, // Reserve Capacity (RC)





            //    // For Daikin Air Conditioner
            //    new Product_Attributes { ProductsID = 3, AttributesID = 7, Discrete_Attribute_Value_ID = 13, Min_Continuous_Attribute_Value = 12000, Max_Continuous_Attribute_Value = 12000 }, // BTU
            //    new Product_Attributes { ProductsID = 3, AttributesID = 8, Discrete_Attribute_Value_ID = 14, Min_Continuous_Attribute_Value = 9.5, Max_Continuous_Attribute_Value = 9.5 }, // Energy Efficiency Rating
            //    new Product_Attributes { ProductsID = 3, AttributesID = 9, Discrete_Attribute_Value_ID = 15, Min_Continuous_Attribute_Value = 30, Max_Continuous_Attribute_Value = 30 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 3, AttributesID = 10, Discrete_Attribute_Value_ID = 16, Min_Continuous_Attribute_Value = 55, Max_Continuous_Attribute_Value = 55 }, // Noise Level (dB)
            //    new Product_Attributes { ProductsID = 3, AttributesID = 11, Discrete_Attribute_Value_ID = 17 }, // Brand
            //    new Product_Attributes { ProductsID = 3, AttributesID = 12, Discrete_Attribute_Value_ID = 18 }, // Type
            //    //add new product attributes
            //    new Product_Attributes { ProductsID = 3, AttributesID = 50, Discrete_Attribute_Value_ID = 31, Min_Continuous_Attribute_Value = 2006, Max_Continuous_Attribute_Value = 2006 }, // Model Year


            //    // For Samsung Air Conditioner
            //    new Product_Attributes { ProductsID = 4, AttributesID = 7, Discrete_Attribute_Value_ID = 19, Min_Continuous_Attribute_Value = 18000, Max_Continuous_Attribute_Value = 18000 }, // BTU
            //    new Product_Attributes { ProductsID = 4, AttributesID = 8, Discrete_Attribute_Value_ID = 20, Min_Continuous_Attribute_Value = 2, Max_Continuous_Attribute_Value = 2 }, // Energy Efficiency Rating
            //    new Product_Attributes { ProductsID = 4, AttributesID = 9, Discrete_Attribute_Value_ID = 21, Min_Continuous_Attribute_Value = 85, Max_Continuous_Attribute_Value = 85 }, // Weight (Kg)
            //    new Product_Attributes { ProductsID = 4, AttributesID = 10, Discrete_Attribute_Value_ID = 22, Min_Continuous_Attribute_Value = 97, Max_Continuous_Attribute_Value = 97 }, // Noise Level (dB)
            //    new Product_Attributes { ProductsID = 4, AttributesID = 11, Discrete_Attribute_Value_ID = 23 }, // Brand
            //    new Product_Attributes { ProductsID = 4, AttributesID = 12, Discrete_Attribute_Value_ID = 24 }, // Type
            //    //add new product attributes
            //    new Product_Attributes { ProductsID = 4, AttributesID = 50, Discrete_Attribute_Value_ID = 32, Min_Continuous_Attribute_Value = 2010, Max_Continuous_Attribute_Value = 2010 }, // Model Year
            //};
            //productAttributes.ForEach(s => context.Product_Attributes.Add(s));
            //context.SaveChanges();
        }


    }
}
