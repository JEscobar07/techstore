using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techstore.Repositories;

namespace techstore.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsGetController : ProductsController
    {
        public ProductsGetController(IProductRepository productRepository) : base(productRepository)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _productRepository.GetAll());
        }
    }
}