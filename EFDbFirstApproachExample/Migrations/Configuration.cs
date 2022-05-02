namespace EFDbFirstApproachExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Company.DataLayer.CompanyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Company.DataLayer.CompanyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.Brands.AddOrUpdate(new Models.Brand() { BrandID = 1, BrandName = "Samsung" });
            //context.Categories.AddOrUpdate(new Models.Category() { CategoryID = 1, CategoryName = "Electronics" });
            //context.Products.AddOrUpdate(new Models.Product() { ProductID = 1, ProductName = "Samsung Galaxy Mobile", CategoryID = 1, DOP = DateTime.Now, Active = true, BrandID = 1, Photo = null, Price = 10000, AvailabilityStatus = "InStock" });
        }
    }
}


