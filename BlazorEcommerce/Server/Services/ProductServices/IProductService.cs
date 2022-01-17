using BlazorEcommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task <ServiceResponce<List<Product>>> GetProducts();

        Task<ServiceResponce<Product>> GetProductById(int id);
    }
}
