using Microsoft.EntityFrameworkCore;
using Store.DAL.Repository.Contracts;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DAL.Repository
{
    public class ProductsToSuppliersRepository : IProductsToSuppliersRepository
    {
        private readonly StoreDbContext _context;

        public ProductsToSuppliersRepository(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddProductToSupplierAsync(ProductsToSuppliers productToSupplier)
        {
            if (productToSupplier == null)
                throw new ArgumentNullException("Received an empty object");

            await _context.ProductsToSuppliers.AddAsync(productToSupplier);
            await _context.SaveChangesAsync();

            return productToSupplier.ProductsToSuppliersId;
        }

        public async Task DeleteProductToSupplierAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var productToSupplier = await _context.ProductsToSuppliers.SingleAsync(x => x.ProductsToSuppliersId == id && !x.IsDeleted);

            productToSupplier.IsDeleted = true;
            _context.ProductsToSuppliers.Update(productToSupplier);

            await _context.SaveChangesAsync();
        }

        public async Task<List<int>> GetProductIdsOfSupplierAsync(int supplierId)
        {
            if (supplierId < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var supplierIds = await _context.ProductsToSuppliers.Where(x => x.SupplierId == supplierId).Select(x => x.ProductId).ToListAsync();

            return supplierIds;
        }

        public async Task<List<ProductsToSuppliers>> GetProductsToSuppliersAsync()
        {
            var productsToSuppliers = await _context.ProductsToSuppliers.Where(x => !x.IsDeleted).ToListAsync();

            return productsToSuppliers;
        }

        public async Task<ProductsToSuppliers> GetProductToSupplierAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var producsToSupplier = await _context.ProductsToSuppliers.SingleAsync(x => x.ProductsToSuppliersId == id && !x.IsDeleted);

            return producsToSupplier;
        }

        public async Task<List<int>> GetSupplierIdsOfProductAsync(int productId)
        {
            if (productId < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var supplierIds = await _context.ProductsToSuppliers.Where(x => x.ProductId == productId).Select(x => x.SupplierId).ToListAsync();

            return supplierIds;
        }

        public async Task<int> UpdateProductToSupplierAsync(ProductsToSuppliers productToSupplier)
        {
            if (productToSupplier == null)
                throw new ArgumentNullException("Received an empty object");

            _context.ProductsToSuppliers.Update(productToSupplier);
            await _context.SaveChangesAsync();

            return productToSupplier.ProductsToSuppliersId;
        }
    }
}
