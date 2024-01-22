using Microsoft.EntityFrameworkCore;
using Store.DAL.Repository.Contracts;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DAL.Repository
{
    public class ServicesToSuppliersRepository : IServicesToSuppliersRepository
    {
        private readonly StoreDbContext _context;

        public ServicesToSuppliersRepository(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddServiceToSupplierAsync(ServicesToSuppliers serviceToSupplier)
        {
            if (serviceToSupplier == null)
                throw new ArgumentNullException("Received an empty object");

            await _context.ServicesToSuppliers.AddAsync(serviceToSupplier);
            await _context.SaveChangesAsync();

            return serviceToSupplier.ServicesToSuppliersId;
        }

        public async Task DeleteProductToSupplierAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var serviceToSupplier = await _context.ServicesToSuppliers.SingleAsync(x => x.ServicesToSuppliersId == id && !x.IsDeleted);

            serviceToSupplier.IsDeleted = true;
            _context.ServicesToSuppliers.Update(serviceToSupplier);

            await _context.SaveChangesAsync();
        }

        public async Task<List<ServicesToSuppliers>> GetServicesToSuppliersAsync()
        {
            var servicesToSuppliers = await _context.ServicesToSuppliers.Where(x => !x.IsDeleted).ToListAsync();

            return servicesToSuppliers;
        }

        public async Task<ServicesToSuppliers> GetServiceToSupplierAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var serviceToSupplier = await _context.ServicesToSuppliers.SingleAsync(x => x.ServicesToSuppliersId == id && !x.IsDeleted);

            return serviceToSupplier;
        }

        public async Task<List<int>> GetServiceIdsOfSupplierAsync(int supplierId)
        {
            if (supplierId < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var serviceIds = await _context.ServicesToSuppliers.Where(x => x.SupplierId == supplierId).Select(x => x.ServiceId).ToListAsync();

            return serviceIds;
        }

        public async Task<List<int>> GetSupplierIdsOfServiceAsync(int serviceId)
        {
            if (serviceId < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var supplierIds = await _context.ServicesToSuppliers.Where(x => x.ServiceId == serviceId).Select(x => x.SupplierId).ToListAsync();

            return supplierIds;
        }

        public async Task<int> UpdateServiceToSupplierAsync(ServicesToSuppliers serviceToSupplier)
        {
            if (serviceToSupplier == null)
                throw new ArgumentNullException("Received an empty object");

            _context.ServicesToSuppliers.Update(serviceToSupplier);
            await _context.SaveChangesAsync();

            return serviceToSupplier.ServicesToSuppliersId;
        }
    }
}
