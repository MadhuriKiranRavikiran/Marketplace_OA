namespace RepositoryLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attribute_Values",
                c => new
                    {
                        Attribute_ValuesID = c.Int(nullable: false, identity: true),
                        AttributesID = c.Int(),
                        Attribute_Value = c.String(),
                    })
                .PrimaryKey(t => t.Attribute_ValuesID)
                .ForeignKey("dbo.Attributes", t => t.AttributesID)
                .Index(t => t.AttributesID);
            
            CreateTable(
                "dbo.Attributes",
                c => new
                    {
                        AttributesID = c.Int(nullable: false, identity: true),
                        Attribute_Name = c.String(),
                        min_value = c.Double(),
                        max_value = c.Double(),
                        Value_Type = c.String(),
                        CategoriesID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AttributesID)
                .ForeignKey("dbo.Categories", t => t.CategoriesID, cascadeDelete: true)
                .Index(t => t.CategoriesID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoriesID = c.Int(nullable: false, identity: true),
                        Category_Name = c.String(),
                        MainCategoriesID = c.Int(),
                    })
                .PrimaryKey(t => t.CategoriesID)
                .ForeignKey("dbo.MainCategories", t => t.MainCategoriesID)
                .Index(t => t.MainCategoriesID);
            
            CreateTable(
                "dbo.MainCategories",
                c => new
                    {
                        MainCategoriesID = c.Int(nullable: false, identity: true),
                        Main_Category_Name = c.String(),
                    })
                .PrimaryKey(t => t.MainCategoriesID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductsID = c.Int(nullable: false, identity: true),
                        Product_Name = c.String(),
                        Description = c.String(),
                        Image_URL = c.String(),
                        CategoriesID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductsID)
                .ForeignKey("dbo.Categories", t => t.CategoriesID)
                .Index(t => t.CategoriesID);
            
            CreateTable(
                "dbo.Product_Attributes",
                c => new
                    {
                        ProductsID = c.Int(nullable: false),
                        AttributesID = c.Int(nullable: false),
                        Discrete_Attribute_Value_ID = c.Int(),
                        Min_Continuous_Attribute_Value = c.Double(),
                        Max_Continuous_Attribute_Value = c.Double(),
                    })
                .PrimaryKey(t => new { t.ProductsID, t.AttributesID })
                .ForeignKey("dbo.Attribute_Values", t => t.Discrete_Attribute_Value_ID)
                .ForeignKey("dbo.Attributes", t => t.AttributesID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductsID, cascadeDelete: true)
                .Index(t => t.ProductsID)
                .Index(t => t.AttributesID)
                .Index(t => t.Discrete_Attribute_Value_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UsersID = c.Int(nullable: false, identity: true),
                        User_Name = c.String(),
                        User_Email = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.UsersID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product_Attributes", "ProductsID", "dbo.Products");
            DropForeignKey("dbo.Product_Attributes", "AttributesID", "dbo.Attributes");
            DropForeignKey("dbo.Product_Attributes", "Discrete_Attribute_Value_ID", "dbo.Attribute_Values");
            DropForeignKey("dbo.Products", "CategoriesID", "dbo.Categories");
            DropForeignKey("dbo.Categories", "MainCategoriesID", "dbo.MainCategories");
            DropForeignKey("dbo.Attributes", "CategoriesID", "dbo.Categories");
            DropForeignKey("dbo.Attribute_Values", "AttributesID", "dbo.Attributes");
            DropIndex("dbo.Product_Attributes", new[] { "Discrete_Attribute_Value_ID" });
            DropIndex("dbo.Product_Attributes", new[] { "AttributesID" });
            DropIndex("dbo.Product_Attributes", new[] { "ProductsID" });
            DropIndex("dbo.Products", new[] { "CategoriesID" });
            DropIndex("dbo.Categories", new[] { "MainCategoriesID" });
            DropIndex("dbo.Attributes", new[] { "CategoriesID" });
            DropIndex("dbo.Attribute_Values", new[] { "AttributesID" });
            DropTable("dbo.Users");
            DropTable("dbo.Product_Attributes");
            DropTable("dbo.Products");
            DropTable("dbo.MainCategories");
            DropTable("dbo.Categories");
            DropTable("dbo.Attributes");
            DropTable("dbo.Attribute_Values");
        }
    }
}
