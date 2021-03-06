using MyPos.DAL.Entity;
using System.Data.Entity.Migrations;

namespace MyPos.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MyPos.DAL.Context.MyPosDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyPos.DAL.Context.MyPosDbContext context)
        {
            context.Customers.AddOrUpdate(e => e.CustomerName,
                 new Customer()
                 {
                     CustomerName = "Sam",
                     CustomerAddress = "Colombo",
                     CustomerEMail = "Sam@gmail.com"

                 }, new Customer()
                 {
                     CustomerName = "Adam",
                     CustomerAddress = "Kalutara",
                     CustomerEMail = "Adam@gmail.com"

                 },
                new Customer()
                {
                    CustomerName = "Mark",
                    CustomerAddress = "Negambo",
                    CustomerEMail = "Mark@gmail.com"

                });
            context.Products.AddOrUpdate(e => e.ProductName,
                    new Product
                    {
                        ProductName = "Anchor",
                        ProductCurrentPrice = 60,
                        ProductDescription = "Milk",
                        ProductStockAvailable = 60
                    },
                     new Product
                     {
                         ProductName = "Samon",
                         ProductCurrentPrice = 70,
                         ProductDescription = "Fish",
                         ProductStockAvailable = 70
                     }, new Product
                     {
                         ProductName = "Sunlight",
                         ProductCurrentPrice = 20,
                         ProductDescription = "Soap",
                         ProductStockAvailable = 90
                     });
        }
    }
}
