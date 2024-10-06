using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techstore.Services;

namespace techstore.Controllers
{
    [ApiController]
    [Route("api/v1/products")]
    public class ProductsController : ControllerBase
    {
        protected readonly ProductServices _productService;

        public ProductsController(ProductServices productServices)
        {
            _productService = productServices;
        }
    }
}