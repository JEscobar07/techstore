using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techstore.DTOs;
using techstore.Models;
using techstore.Services;

namespace techstore.Controllers.v1
{
    [ApiController]
    [Route("api/v1/products")]
    public class ProductsCreateController : ProductsController
    {
        public ProductsCreateController(ProductServices productServices) : base(productServices)
        {
        }

        [HttpPost]
        public async Task<IActionResult> PostCreateProducts([FromBody] ProductDTO product ){
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            var productSave = new Product{
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                AmountProducts  =  product.AmountProducts,
                IdCategory = product.IdCategory
            };
            await _productService.Add(productSave);
            return Ok("Producto guardado con exito");
        }
    }
}