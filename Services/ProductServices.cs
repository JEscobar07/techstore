using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techstore.Data;
using techstore.Models;
using techstore.Repositories;

namespace techstore.Services
{
    public class ProductServices : IProductRepository
    {
        private readonly AppDbContext context;

        public ProductServices(AppDbContext _context)
        {
            context = _context;
        }

        public async Task Add(Product product)
        {
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var productFound = await context.Products.FindAsync(id);
            if (productFound != null)
            {
                context.Products.Remove(productFound);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Product?> Update(int id, Product product)
        {
            var productFound = await context.Products.FindAsync(id);
            if (productFound != null)
            {
                productFound.Name = product.Name;
                productFound.Description = product.Description;
                productFound.Price = product.Price;
                productFound.AmountProducts = product.AmountProducts;
                productFound.IdCategory = product.IdCategory;
                await context.SaveChangesAsync();
                return productFound;
            }
            else
            {
                return productFound;
            }
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await context.Products.Include(r => r.Category).ToListAsync();
        }


    }
}