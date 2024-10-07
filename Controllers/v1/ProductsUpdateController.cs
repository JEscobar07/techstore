using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techstore.DTOs;
using techstore.Models;
using techstore.Repositories;

namespace techstore.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsUpdateController : ProductsController
    {
        public ProductsUpdateController(IProductRepository productRepository) : base(productRepository)
        {
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUpdateProducts([FromRoute] int id,[FromBody] ProductDTO product)
        {
            var productSave = new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                AmountProducts = product.AmountProducts,
                IdCategory = product.IdCategory
            };
            if(await _productRepository.Update(id,productSave) == null){
                return NotFound("Producto no encontrado");
            }else{
                return Ok("Producto actualizado con exito");
            }
          
        }
    }
}