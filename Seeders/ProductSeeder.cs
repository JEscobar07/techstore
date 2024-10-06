using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techstore.Models;
using Bogus;

namespace techstore.Seeders
{
    public class ProductSeeder
    {
        public static void Seed(ModelBuilder modelBuilder, int amout)
        {
            var products = GenerateProducts(amout);
            modelBuilder.Entity<Product>().HasData(products);
        }

        public static IEnumerable<Product> GenerateProducts(int count)
        {
            var faker = new Faker<Product>()
                .RuleFor(a => a.Id, f => f.IndexFaker + 1)
                .RuleFor(a => a.Name, f => f.Person.FirstName)
                .RuleFor(a => a.Description, f => f.Commerce.ProductDescription())
                .RuleFor(a => a.Price, f => f.Random.Double(100, 100000))
                .RuleFor(a => a.AmountProducts, f => f.PickRandom(10, 15, 20))
                .RuleFor(a => a.IdCategory, f => f.PickRandom(1, 2, 3, 4, 5, 6, 7, 8));

            return faker.Generate(count);
        }
    }
}
