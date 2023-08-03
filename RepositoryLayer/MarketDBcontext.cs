using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class MarketDBContext : DbContext
    {
        public MarketDBContext() : base("MarketDBContext")
        {
        }

        public DbSet<Products> Products { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<MainCategories> MainCategories { get; set; }

        public DbSet<Attributes> Attributes { get; set; }

        public DbSet<Attribute_Values> Attribute_Values { get; set; }

        public DbSet<Product_Attributes> Product_Attributes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

