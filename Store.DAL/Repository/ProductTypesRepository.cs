using Microsoft.EntityFrameworkCore;
using Store.DAL.Repository.Contracts;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DAL.Repository
{
    public class ProductTypesRepository : IProductTypesRepository
    {
        private readonly StoreDbContext _context;

        public ProductTypesRepository(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<ProductTypes> GetProductTypeAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var productType = await _context.ProductTypes.SingleAsync(x => x.Id == id);

            return productType;
        }

        public async Task<List<ProductTypes>> GetProductTypesAsync()
        {
            var productTypes = await _context.ProductTypes.ToListAsync();

            return productTypes;
        }
    }
}
