using InvoiceApp.API.Data;
using InvoiceApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Product>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            if (products != null)
                return products;
            return new List<Product>();
        }
    }
}
