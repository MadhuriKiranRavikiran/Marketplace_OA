namespace RepositoryLayer.Migrations
{
    using DomainLayer.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RepositoryLayer.MarketDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepositoryLayer.MarketDBContext context)
        {

            // write your code here to add intial data

            //var products = new List<Product>
            //{
            //    new Product { ProductName = "Product A", Category = "Category X" },
            //    new Product { ProductName = "Product B", Category = "Category Y" },
            //    new Product { ProductName = "Product C", Category = "Category Z" },

            //};


            //products.ForEach(product => context.Products.Add(product));


            //context.SaveChanges();
            var users = new List<Users>
            {
                new Users {User_ID = 1, User_Name = "test", User_Email = "test@test", Password = "123"}
            };


            var mainCategories = new List<MainCategories>
            {
                new MainCategories { Main_Category_ID = 1, Main_Category_Name = "Mechanical" },
                new MainCategories { Main_Category_ID = 2, Main_Category_Name = "Electrical" },
                new MainCategories { Main_Category_ID = 3, Main_Category_Name = "Stationery" },
                new MainCategories { Main_Category_ID = 4, Main_Category_Name = "Furniture" }
            };
            mainCategories.ForEach(s => context.MainCategories.Add(s));
            context.SaveChanges();

            var subCategories = new List<Categories>
            {
                new Categories { Category_ID = 1, Category_Name = "Car Battery", Main_Category_ID = 1 },
                new Categories { Category_ID = 2, Category_Name = "Air Conditioner", Main_Category_ID = 1 },
                new Categories { Category_ID = 3, Category_Name = "Desk Lamp", Main_Category_ID = 2 },
                new Categories { Category_ID = 4, Category_Name = "Electric Drill", Main_Category_ID = 2 },
                new Categories { Category_ID = 5, Category_Name = "Fountain Pen", Main_Category_ID = 3 },
                new Categories { Category_ID = 6, Category_Name = "Spiral Notebook", Main_Category_ID = 3 },
                new Categories { Category_ID = 7, Category_Name = "Office Chair", Main_Category_ID = 4 },
                new Categories { Category_ID = 8, Category_Name = "Sofa", Main_Category_ID = 4 }
            };
            subCategories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            //// one formate for attribtues table, unique attributes, one attributes may belong to many categories
            //var attributes = new List<Attributes>
            //{
            //    new Attributes { Attribute_ID = 1, Attribute_Name = "Capacity (Ah)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 2, Attribute_Name = "Warranty (Years)", min_value = 0, max_value = 100, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 3, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 4, Attribute_Name = "Voltage (V)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 5, Attribute_Name = "Brand", Value_Type = "String" },
            //    new Attributes { Attribute_ID = 6, Attribute_Name = "Type", Value_Type = "String" },
            //    new Attributes { Attribute_ID = 7, Attribute_Name = "BTU", min_value = 0, max_value = 100000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 8, Attribute_Name = "Energy Efficiency Rating", min_value = 0, max_value = 10, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 9, Attribute_Name = "Noise Level (dB)", min_value = 0, max_value = 150, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 10, Attribute_Name = "Wattage (W)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 11, Attribute_Name = "Height (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 12, Attribute_Name = "Lifespan (Hours)", min_value = 0, max_value = 1000000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 13, Attribute_Name = "Color", Value_Type = "String" },
            //    new Attributes { Attribute_ID = 14, Attribute_Name = "Material", Value_Type = "String" },
            //    new Attributes { Attribute_ID = 15, Attribute_Name = "Power (W)", min_value = 0, max_value = 10000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 16, Attribute_Name = "Speed (RPM)", min_value = 0, max_value = 30000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 17, Attribute_Name = "Cable Length (M)", min_value = 0, max_value = 100, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 18, Attribute_Name = "Length (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 19, Attribute_Name = "Weight (g)", min_value = 0, max_value = 10000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 20, Attribute_Name = "Diameter (mm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 21, Attribute_Name = "Pages", min_value = 0, max_value = 10000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 22, Attribute_Name = "Width (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 23, Attribute_Name = "Weight Capacity (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number" },
            //    new Attributes { Attribute_ID = 24, Attribute_Name = "Depth (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
            //};
            //attributes.ForEach(s => context.Attributes.Add(s));
            //context.SaveChanges();

            // Another formate, each category 6 rows
            var attributes2 = new List<Attributes>
            {
                // Subcategory: Car Battery
                new Attributes { Attribute_ID = 1, Attribute_Name = "Capacity (Ah)", min_value = 0, max_value = 1000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 2, Attribute_Name = "Warranty (Years)", min_value = 0, max_value = 100, Value_Type = "Number" },
                new Attributes { Attribute_ID = 3, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 4, Attribute_Name = "Voltage (V)", min_value = 0, max_value = 1000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 5, Attribute_Name = "Brand", Value_Type = "Text" },
                new Attributes { Attribute_ID = 6, Attribute_Name = "Type", Value_Type = "Text" },

                // Subcategory: Air Conditioner
                new Attributes { Attribute_ID = 7, Attribute_Name = "BTU", min_value = 0, max_value = 30000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 8, Attribute_Name = "Energy Efficiency Rating", min_value = 0, max_value = 10, Value_Type = "Number" },
                new Attributes { Attribute_ID = 9, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 10, Attribute_Name = "Noise Level (dB)", min_value = 0, max_value = 100, Value_Type = "Number" },
                new Attributes { Attribute_ID = 11, Attribute_Name = "Brand", Value_Type = "Text" },
                new Attributes { Attribute_ID = 12, Attribute_Name = "Type", Value_Type = "Text" },

            // Subcategory: Desk Lamp
                new Attributes { Attribute_ID = 13, Attribute_Name = "Wattage (W)", min_value = 0, max_value = 1000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 14, Attribute_Name = "Height (cm)", min_value = 0, max_value = 200, Value_Type = "Number" },
                new Attributes { Attribute_ID = 15, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 100, Value_Type = "Number" },
                new Attributes { Attribute_ID = 16, Attribute_Name = "Lifespan (Hours)", min_value = 0, max_value = 100000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 17, Attribute_Name = "Color", Value_Type = "Text" },
                new Attributes { Attribute_ID = 18, Attribute_Name = "Material", Value_Type = "Text" },

                // Subcategory: Electric Drill
                new Attributes { Attribute_ID = 19, Attribute_Name = "Power (W)", min_value = 0, max_value = 1000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 20, Attribute_Name = "Speed (RPM)", min_value = 0, max_value = 5000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 21, Attribute_Name = "Weight (Kg)", min_value = 0, max_value = 100, Value_Type = "Number" },
                new Attributes { Attribute_ID = 22, Attribute_Name = "Cable Length (M)", min_value = 0, max_value = 50, Value_Type = "Number" },
                new Attributes { Attribute_ID = 23, Attribute_Name = "Color", Value_Type = "Text" },
                new Attributes { Attribute_ID = 24, Attribute_Name = "Material", Value_Type = "Text" },

                // Subcategory: Fountain Pen
                new Attributes { Attribute_ID = 25, Attribute_Name = "Length (cm)", min_value = 0, max_value = 50, Value_Type = "Number" },
                new Attributes { Attribute_ID = 26, Attribute_Name = "Weight (g)", min_value = 0, max_value = 1000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 27, Attribute_Name = "Diameter (mm)", min_value = 0, max_value = 50, Value_Type = "Number" },
                new Attributes { Attribute_ID = 28, Attribute_Name = "Warranty (Years)", min_value = 0, max_value = 100, Value_Type = "Number" },
                new Attributes { Attribute_ID = 29, Attribute_Name = "Color", Value_Type = "Text" },
                new Attributes { Attribute_ID = 30, Attribute_Name = "Material", Value_Type = "Text" },

                // Subcategory: Spiral Notebook
                new Attributes { Attribute_ID = 31, Attribute_Name = "Pages", min_value = 0, max_value = 1000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 32, Attribute_Name = "Weight (g)", min_value = 0, max_value = 5000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 33, Attribute_Name = "Width (cm)", min_value = 0, max_value = 50, Value_Type = "Number" },
                new Attributes { Attribute_ID = 34, Attribute_Name = "Height (cm)", min_value = 0, max_value = 50, Value_Type = "Number" },
                new Attributes { Attribute_ID = 35, Attribute_Name = "Color", Value_Type = "Text" },
                new Attributes { Attribute_ID = 36, Attribute_Name = "Material", Value_Type = "Text" },

                // Subcategory: Office Chair
                // Subcategory: Sofa
                    // Subcategory: Office Chair
                new Attributes { Attribute_ID = 37, Attribute_Name = "Weight Capacity (Kg)", min_value = 0, max_value = 500, Value_Type = "Number" },
                new Attributes { Attribute_ID = 38, Attribute_Name = "Height (cm)", min_value = 0, max_value = 200, Value_Type = "Number" },
                new Attributes { Attribute_ID = 39, Attribute_Name = "Width (cm)", min_value = 0, max_value = 200, Value_Type = "Number" },
                new Attributes { Attribute_ID = 40, Attribute_Name = "Depth (cm)", min_value = 0, max_value = 200, Value_Type = "Number" },
                new Attributes { Attribute_ID = 41, Attribute_Name = "Color", Value_Type = "Text" },
                new Attributes { Attribute_ID = 42, Attribute_Name = "Material", Value_Type = "Text" },

                // Subcategory: Sofa
                new Attributes { Attribute_ID = 43, Attribute_Name = "Weight Capacity (Kg)", min_value = 0, max_value = 1000, Value_Type = "Number" },
                new Attributes { Attribute_ID = 44, Attribute_Name = "Width (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
                new Attributes { Attribute_ID = 45, Attribute_Name = "Height (cm)", min_value = 0, max_value = 200, Value_Type = "Number" },
                new Attributes { Attribute_ID = 46, Attribute_Name = "Depth (cm)", min_value = 0, max_value = 500, Value_Type = "Number" },
                new Attributes { Attribute_ID = 47, Attribute_Name = "Color", Value_Type = "Text" },
                new Attributes { Attribute_ID = 48, Attribute_Name = "Material", Value_Type = "Text" },

            };
            attributes2.ForEach(s => context.Attributes.Add(s));
            context.SaveChanges();


            var products = new List<Products>
            {
                new Products { Product_ID = 1, Product_Name = "Exide Car Battery 60 Ah", Description = "Exide Car Battery 60 Ah Description", Image_URL = "image1.png", Category_ID = 1 },
                new Products { Product_ID = 2, Product_Name = "Amaron Car Battery 80 Ah", Description = "Amaron Car Battery 80 Ah Description", Image_URL = "image2.png", Category_ID = 1 },
                new Products { Product_ID = 3, Product_Name = "Daikin Air Conditioner 12000 BTU", Description = "Daikin Air Conditioner 12000 BTU Description", Image_URL = "image3.png", Category_ID = 2 },
                new Products { Product_ID = 4, Product_Name = "Samsung Air Conditioner 18000 BTU", Description = "Samsung Air Conditioner 18000 BTU Description", Image_URL = "image4.png", Category_ID = 2 },
                new Products { Product_ID = 5, Product_Name = "Philips Desk Lamp 60 Watts", Description = "Philips Desk Lamp 60 Watts Description", Image_URL = "image5.png", Category_ID = 3 },
                new Products { Product_ID = 6, Product_Name = "Ikea Desk Lamp 10 Watts", Description = "Ikea Desk Lamp 10 Watts Description", Image_URL = "image6.png", Category_ID = 3 },
                new Products { Product_ID = 7, Product_Name = "Bosch Electric Drill 600 Watts", Description = "Bosch Electric Drill 600 Watts Description", Image_URL = "image7.png", Category_ID = 4 },
                new Products { Product_ID = 8, Product_Name = "Black & Decker Electric Drill 550 Watts", Description = "Black & Decker Electric Drill 550 Watts Description", Image_URL = "image8.png", Category_ID = 4 },
                new Products { Product_ID = 9, Product_Name = "Parker Fountain Pen", Description = "Parker Fountain Pen Description", Image_URL = "image9.png", Category_ID = 5 },
                new Products { Product_ID = 10, Product_Name = "Montblanc Fountain Pen", Description = "Montblanc Fountain Pen Description", Image_URL = "image10.png", Category_ID = 5 },
                new Products { Product_ID = 11, Product_Name = "Moleskine Spiral Notebook 200 Pages", Description = "Moleskine Spiral Notebook 200 Pages Description", Image_URL = "image11.png", Category_ID = 6 },
                new Products { Product_ID = 12, Product_Name = "Oxford Spiral Notebook 100 Pages", Description = "Oxford Spiral Notebook 100 Pages Description", Image_URL = "image12.png", Category_ID = 6 },
                new Products { Product_ID = 13, Product_Name = "Herman Miller Aeron Office Chair", Description = "Herman Miller Aeron Office Chair Description", Image_URL = "image13.png", Category_ID = 7 },
                new Products { Product_ID = 14, Product_Name = "Steelcase Gesture Office Chair", Description = "Steelcase Gesture Office Chair Description", Image_URL = "image14.png", Category_ID = 7 },
                new Products { Product_ID = 15, Product_Name = "Ashley Furniture Leather Sofa", Description = "Ashley Furniture Leather Sofa Description", Image_URL = "image15.png", Category_ID = 8 },
                new Products { Product_ID = 16, Product_Name = "Ikea Ektorp Fabric Sofa", Description = "Ikea Ektorp Fabric Sofa Description", Image_URL = "image16.png", Category_ID = 8 }
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            // only for first main category and its two subcategory products
            var attributeValues = new List<Attribute_Values>
            {
                // For Exide Car Battery
                new Attribute_Values { Attribute_Value_ID = 1, Attribute_ID = 1, Attribute_Value = "60" }, // Capacity (Ah)
                new Attribute_Values { Attribute_Value_ID = 2, Attribute_ID = 2, Attribute_Value = "3" }, // Warranty (Years)
                new Attribute_Values { Attribute_Value_ID = 3, Attribute_ID = 3, Attribute_Value = "15.2" }, // Weight (Kg)
                new Attribute_Values { Attribute_Value_ID = 4, Attribute_ID = 4, Attribute_Value = "12" }, // Voltage (V)
                new Attribute_Values { Attribute_Value_ID = 5, Attribute_ID = 5, Attribute_Value = "Exide" }, // Brand
                new Attribute_Values { Attribute_Value_ID = 6, Attribute_ID = 6, Attribute_Value = "Wet Battery" }, // Type

                // For Amaron Car Battery
                new Attribute_Values { Attribute_Value_ID = 7, Attribute_ID = 1, Attribute_Value = "80" }, // Capacity (Ah)
                new Attribute_Values { Attribute_Value_ID = 8, Attribute_ID = 2, Attribute_Value = "4" }, // Warranty (Years)
                new Attribute_Values { Attribute_Value_ID = 9, Attribute_ID = 3, Attribute_Value = "18.3" }, // Weight (Kg)
                new Attribute_Values { Attribute_Value_ID = 10, Attribute_ID = 4, Attribute_Value = "12" }, // Voltage (V)
                new Attribute_Values { Attribute_Value_ID = 11, Attribute_ID = 5, Attribute_Value = "Amaron" }, // Brand
                new Attribute_Values { Attribute_Value_ID = 12, Attribute_ID = 6, Attribute_Value = "Wet Battery" }, // Type

                // For Daikin Air Conditioner
                new Attribute_Values { Attribute_Value_ID = 13, Attribute_ID = 7, Attribute_Value = "12000" }, // BTU
                new Attribute_Values { Attribute_Value_ID = 14, Attribute_ID = 8, Attribute_Value = "9.5" }, // Energy Efficiency Rating
                new Attribute_Values { Attribute_Value_ID = 15, Attribute_ID = 9, Attribute_Value = "30" }, // Weight (Kg)
                new Attribute_Values { Attribute_Value_ID = 16, Attribute_ID = 10, Attribute_Value = "55" }, // Noise Level (dB)
                new Attribute_Values { Attribute_Value_ID = 17, Attribute_ID = 11, Attribute_Value = "Daikin" }, // Brand
                new Attribute_Values { Attribute_Value_ID = 18, Attribute_ID = 12, Attribute_Value = "Split System" }, // Type

                // For Samsung Air Conditioner
                new Attribute_Values { Attribute_Value_ID = 19, Attribute_ID = 7, Attribute_Value = "18000" }, // BTU
                new Attribute_Values { Attribute_Value_ID = 20, Attribute_ID = 8, Attribute_Value = "9" }, // Energy Efficiency Rating
                new Attribute_Values { Attribute_Value_ID = 21, Attribute_ID = 9, Attribute_Value = "35" }, // Weight (Kg)
                new Attribute_Values { Attribute_Value_ID = 22, Attribute_ID = 10, Attribute_Value = "57" }, // Noise Level (dB)
                new Attribute_Values { Attribute_Value_ID = 23, Attribute_ID = 11, Attribute_Value = "Samsung" }, // Brand
                new Attribute_Values { Attribute_Value_ID = 24, Attribute_ID = 12, Attribute_Value = "Split System" } // Type
            };
            attributeValues.ForEach(s => context.Attribute_Values.Add(s));
            context.SaveChanges();


            // only for first main category and its two subcategory products
            var productAttributes = new List<Product_Attributes>
            {
                // For Exide Car Battery
                new Product_Attributes { Product_ID = 1, Attribute_ID = 1, Discrete_Attribute_Value_ID = 1 }, // Capacity (Ah)
                new Product_Attributes { Product_ID = 1, Attribute_ID = 2, Discrete_Attribute_Value_ID = 2 }, // Warranty (Years)
                new Product_Attributes { Product_ID = 1, Attribute_ID = 3, Discrete_Attribute_Value_ID = 3 }, // Weight (Kg)
                new Product_Attributes { Product_ID = 1, Attribute_ID = 4, Discrete_Attribute_Value_ID = 4 }, // Voltage (V)
                new Product_Attributes { Product_ID = 1, Attribute_ID = 5, Discrete_Attribute_Value_ID = 5 }, // Brand
                new Product_Attributes { Product_ID = 1, Attribute_ID = 6, Discrete_Attribute_Value_ID = 6 }, // Type

                // For Amaron Car Battery
                new Product_Attributes { Product_ID = 2, Attribute_ID = 1, Discrete_Attribute_Value_ID = 7 }, // Capacity (Ah)
                new Product_Attributes { Product_ID = 2, Attribute_ID = 2, Discrete_Attribute_Value_ID = 8 }, // Warranty (Years)
                new Product_Attributes { Product_ID = 2, Attribute_ID = 3, Discrete_Attribute_Value_ID = 9 }, // Weight (Kg)
                new Product_Attributes { Product_ID = 2, Attribute_ID = 4, Discrete_Attribute_Value_ID = 10 }, // Voltage (V)
                new Product_Attributes { Product_ID = 2, Attribute_ID = 5, Discrete_Attribute_Value_ID = 11 }, // Brand
                new Product_Attributes { Product_ID = 2, Attribute_ID = 6, Discrete_Attribute_Value_ID = 12 }, // Type

                // For Daikin Air Conditioner
                new Product_Attributes { Product_ID = 3, Attribute_ID = 7, Discrete_Attribute_Value_ID = 13 }, // BTU
                new Product_Attributes { Product_ID = 3, Attribute_ID = 8, Discrete_Attribute_Value_ID = 14 }, // Energy Efficiency Rating
                new Product_Attributes { Product_ID = 3, Attribute_ID = 9, Discrete_Attribute_Value_ID = 15 }, // Weight (Kg)
                new Product_Attributes { Product_ID = 3, Attribute_ID = 10, Discrete_Attribute_Value_ID = 16 }, // Noise Level (dB)
                new Product_Attributes { Product_ID = 3, Attribute_ID = 11, Discrete_Attribute_Value_ID = 17 }, // Brand
                new Product_Attributes { Product_ID = 3, Attribute_ID = 12, Discrete_Attribute_Value_ID = 18 }, // Type

                // For Samsung Air Conditioner
                new Product_Attributes { Product_ID = 4, Attribute_ID = 7, Discrete_Attribute_Value_ID = 19 }, // BTU
                new Product_Attributes { Product_ID = 4, Attribute_ID = 8, Discrete_Attribute_Value_ID = 20 }, // Energy Efficiency Rating
                new Product_Attributes { Product_ID = 4, Attribute_ID = 9, Discrete_Attribute_Value_ID = 21 }, // Weight (Kg)
                new Product_Attributes { Product_ID = 4, Attribute_ID = 10, Discrete_Attribute_Value_ID = 22 }, // Noise Level (dB)
                new Product_Attributes { Product_ID = 4, Attribute_ID = 11, Discrete_Attribute_Value_ID = 23 }, // Brand
                new Product_Attributes { Product_ID = 4, Attribute_ID = 12, Discrete_Attribute_Value_ID = 24 } // Type
            };
            productAttributes.ForEach(s => context.Product_Attributes.Add(s));
            context.SaveChanges();
        }
    }
}