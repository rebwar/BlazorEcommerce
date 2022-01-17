using BlazorEcommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpclient;

        public List<Category> Categories { get; set; } = new List<Category>();
        public CategoryService(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }

        public async Task GetCategories()
        {
            var response = await _httpclient.GetFromJsonAsync<ServiceResponce<List<Category>>>("api/category");
            Categories = response.Data;
        }
    }
}
