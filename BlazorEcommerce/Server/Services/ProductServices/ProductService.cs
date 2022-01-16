﻿using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponce<Product>> GetProductById(int productId)
        {
            var response = new ServiceResponce<Product>();
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "You product does not exist!";
            }
            else
            {
                response.Data = product;

            }
            return response;

        }

        public async Task<ServiceResponce<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            var response = new ServiceResponce<List<Product>>
            {
                Data = products,
                Message = "Here you go!"
            };

            return response;
        }
    }
}
