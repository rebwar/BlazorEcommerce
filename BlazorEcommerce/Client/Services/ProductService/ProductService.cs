using BlazorEcommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public List<Product> Products { get; set; } = new List<Product>();
        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public async Task GetProducts()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponce<List<Product>>>("api/product");
            Products = response.Data;           
        }

        public async Task<ServiceResponce<Product>> GetProductById(int id)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponce<Product>>($"api/product/{id}");
            return result;
            
        }
    }
}
