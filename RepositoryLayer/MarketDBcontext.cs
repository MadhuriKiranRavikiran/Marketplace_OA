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

        public DbSet<Attributes> Attributes { get; set; }

        public DbSet<AttributesCategory> AttributesCategory { get; set; }

        public DbSet<AttributeValues> AttributeValues { get; set; }

        public DbSet<ProductAttributes> ProductAttributes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

