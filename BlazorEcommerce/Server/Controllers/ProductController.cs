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
        private readonly DataContext _context;
        private readonly IProductService _productservice;

        public ProductController(DataContext context,IProductService productService)
        {
            _context = context;
            _productservice = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponce<List<Product>>>> GetProducts()
        {
            var response = await _productservice.GetProducts();
            return Ok(response);
        }
    }
}
