using BlazorEcommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        public List<Product> Products { get; set; }
        Task GetProducts(string categoryUrl);
        Task<ServiceResponce<Product>> GetProductById(int productId);
        event Action ProductsChanged;
    }
}
