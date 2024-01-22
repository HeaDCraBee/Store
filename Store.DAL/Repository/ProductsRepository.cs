using Microsoft.EntityFrameworkCore;
using Store.DAL.Repository.Contracts;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DAL.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly StoreDbContext _context;

        public ProductsRepository(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddProductAsync(Products product)
        {
            if (product == null) 
                throw new ArgumentNullException("Received an empty object");

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product.ProductId;
        }

        public async Task DeleteProductAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var product = await _context.Products.SingleAsync(x => x.ProductId == id && !x.IsDeleted);

            product.IsDeleted = true;
            _context.Products.Update(product);

            await _context.SaveChangesAsync();
        }

        public async Task<Products> GetProductAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var product = await _context.Products.SingleAsync(x => x.ProductId == id && !x.IsDeleted);

            return product;
        }

        public async Task<List<Products>> GetProductsAsync()
        {
            var products = await _context.Products.Where(x => !x.IsDeleted).ToListAsync();

            return products;
        }

        public async Task<int> UpdateProductAsync(Products product)
        {
            if (product == null)
                throw new ArgumentNullException("Received an empty object");

            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return product.ProductId;
        }
    }
}
