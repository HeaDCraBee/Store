using Store.Business.Mappers;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using Store.DAL.Repository.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Business.Store
{
    public class ServiceTypesService : IServiceTypesService
    {
        private readonly IServiceTypesRepository _serviceTypesRepository;

        public ServiceTypesService(IServiceTypesRepository serviceTypesRepository)
        {
            _serviceTypesRepository = serviceTypesRepository;
        }

        public async Task<ServiceTypesDTO> GetServiceTypeAsync(int id)
        {
            var serviceType = await _serviceTypesRepository.GetServiceTypeAsync(id);

            return serviceType.MapToDto();
        }

        public async Task<List<ServiceTypesDTO>> GetServiceTypesAsync()
        {
            var serviceTypes = await _serviceTypesRepository.GetServiceTypesAsync();

            return serviceTypes.Select(x => x.MapToDto()).ToList();
        }
    }
}
