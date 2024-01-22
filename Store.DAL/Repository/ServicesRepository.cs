using Microsoft.EntityFrameworkCore;
using Store.DAL.Repository.Contracts;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DAL.Repository
{
    public class ServicesRepository : IServicesRepository
    {
        private StoreDbContext _context;

        public ServicesRepository(StoreDbContext context) => _context = context;

        public async Task<int> AddServiceAsync(Services service)
        {
            if (service == null)
                throw new ArgumentNullException("Received an empty object");

            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();

            return service.ServiseId;
        }

        public async Task DeleteServiceAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var service = await _context.Services.SingleAsync(x => x.ServiseId == id && !x.IsDeleted);

            service.IsDeleted = true;
            _context.Services.Update(service);

            await _context.SaveChangesAsync();
        }

        public async Task<Services> GetServiceAsync(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("id can't be less then zero");

            var service = await _context.Services.SingleAsync(x => x.ServiseId == id && !x.IsDeleted);

            return service;
        }

        public async Task<List<Services>> GetServicesAsync() 
        {
            var services = await _context.Services.Where(x => !x.IsDeleted).ToListAsync();

            return services;
        }

        public async Task<int> UpdateServiceAsync(Services service)
        {
            if (service == null)
                throw new ArgumentNullException("Received an emrty object");

            _context.Services.Update(service);
            await _context.SaveChangesAsync();

            return service.ServiseId;
        }
    }
}
