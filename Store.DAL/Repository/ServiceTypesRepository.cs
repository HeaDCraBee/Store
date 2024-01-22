using Microsoft.EntityFrameworkCore;
using Store.DAL.Repository.Contracts;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DAL.Repository
{
    public class ServiceTypesRepository : IServiceTypesRepository
    {
        private readonly StoreDbContext _context;

        public ServiceTypesRepository(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceTypes> GetServiceTypeAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var serviceType = await _context.ServiceTypes.SingleAsync(x => x.Id == id);

            return serviceType;
        }

        public async Task<List<ServiceTypes>> GetServiceTypesAsync()
        {
            var serviceTypes = await _context.ServiceTypes.ToListAsync();

            return serviceTypes;
        }
    }
}
