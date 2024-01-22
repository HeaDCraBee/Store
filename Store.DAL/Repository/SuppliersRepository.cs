using Microsoft.EntityFrameworkCore;
using Store.DAL.Repository.Contracts;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DAL.Repository
{
    public class SuppliersRepository : ISuppliersRepository
    {
        private StoreDbContext _context;

        public SuppliersRepository(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddSupplierAsync(Suppliers supplier)
        {
            if (supplier == null)
                throw new ArgumentNullException("Received an empty object");

            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();

            return supplier.SupplierId;
        }

        public async Task DeleteSupplierAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var supplier = await _context.Suppliers.SingleAsync(x => x.SupplierId == id && !x.IsDeleted);

            supplier.IsDeleted = true;
            _context.Suppliers.Update(supplier);

            await _context.SaveChangesAsync();
        }

        public async Task<Suppliers> GetSupplierAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var supplier = await _context.Suppliers.SingleAsync(x => x.SupplierId == id);

            return supplier;
        }

        public async Task<List<Suppliers>> GetSuppliersAsync()
        {
            var suppliers = await _context.Suppliers.Where(x => !x.IsDeleted).ToListAsync();

            return suppliers;
        }

        public async Task<int> UpdateSupplierAsync(Suppliers supplier)
        {
            if (supplier == null)
                throw new ArgumentNullException("Received an empty object");

            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();

            return supplier.SupplierId;
        }
    }
}
