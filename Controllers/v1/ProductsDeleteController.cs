using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techstore.Repositories;

namespace techstore.Controllers.v1
{
    [ApiController]
    [Route("api/v1/products")]
    public class ProductsDeleteController : ProductsController
    {
        public ProductsDeleteController(IProductRepository productRepository) : base(productRepository)
        {
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducts([FromRoute] int id)
        {
            if (await _productRepository.Delete(id) == true)
            {
                return Ok("Producto eliminado con exito");
            }
            else
            {
                return BadRequest("Lo sentimos pero el producto no esta en nuestro sistema");
            }
            
        }
    }
}