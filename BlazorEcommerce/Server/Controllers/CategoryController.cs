using BlazorEcommerce.Server.Services.CategoryService;
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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryservice;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryservice = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponce<List<Category>>>> GetCategory()
        {
            var result =await _categoryservice.GetCategories();

            return Ok(result);
        }

        
    }
}
