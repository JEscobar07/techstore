using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.Models;

namespace techstore.Repositories
{
    public interface IProductRepository
    {
        public Task Add(Product product);
        public Task<Product> Update(int id, Product product);
        public Task<bool> Delete(int id);
        public Task<IEnumerable<Product>> GetAll();
    }
}