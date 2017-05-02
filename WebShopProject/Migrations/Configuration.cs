namespace WebShopProject.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.WebShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.WebShopContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var products = new List<Product>
            {
            new Product{Name="Hp 15", Price=4000, Description="xxxxx", /*CategoryId=context.Categories.FirstOrDefault(x => x.Name == "Laptop Computer").Id*/ },
            /*new Product{Name="Samsung Ultra HD", Price=2500, Description="xxxxx", CategoryId=context.Categories.FirstOrDefault(x => x.Name == "Blu-ray Player").Id},*/
            /*new Product{Name="APPLE IPhone 5S", Price=3000, Description="xxxxx", CategoryId=context.Categories.FirstOrDefault(x => x.Name == "SmartPhone").Id},*/
            /*new Product{Name="APPLE IPhone 5S", Price=3000, Description="xxxxx", CategoryId=context.Categories.FirstOrDefault(x => x.Name == "SmartPhone").Id},*/
            /*new Product{Name="APPLE IPhone 5S",, Price=3000, Description="xxxxx", CategoryId=context.Categories.FirstOrDefault(x => x.Name == "SmartPhone").Id},*/
            /*new Product{Name="APPLE IPhone 5S",, Price=3000, Description="xxxxx", CategoryId=context.Categories.FirstOrDefault(x => x.Name == "SmartPhone").Id},*/
            /*new Product{Name="APPLE IPhone 5S",, Price=3000, Description="xxxxx", CategoryId=context.Categories.FirstOrDefault(x => x.Name == "SmartPhone").Id}*/
            };

            //products.ForEach(p => context.Products.Add(p));
            //context.SaveChanges();
        }
    }
}