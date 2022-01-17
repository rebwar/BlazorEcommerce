using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Server.Services.ProductServices;
using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productservice;

        public ProductController(IProductService productService)
        {

            _productservice = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponce<List<Product>>>> GetProducts()
        {
            var response = await _productservice.GetProducts();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponce<Product>>> GetProductById(int id)
        {
            var response = await _productservice.GetProductById(id);
            return Ok(response);
        }


    }
}
