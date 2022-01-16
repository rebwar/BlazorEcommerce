using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
       private List<Product> Products = new List<Product>
{
        
    };

        [HttpGet]
        public ActionResult<Task<Product>> GetProducts()
        {
            return Ok(Products);
        }
    }
}
