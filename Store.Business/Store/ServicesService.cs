using Store.Business.Mappers;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using Store.DAL.Repository.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Store
{
    public class ServicesService : IServicesService
    {
        private readonly IServicesRepository _servicesRepository;
        private readonly IServicesToSuppliersRepository _servicesToSuppliersRepository;

        public ServicesService(IServicesRepository servicesRepository, IServicesToSuppliersRepository servicesToSuppliersRepository)
        {
            _servicesRepository = servicesRepository;
            _servicesToSuppliersRepository = servicesToSuppliersRepository;
        }

        public async Task<int> AddServiseAsync(ServicesDTO serviceDto)
        {
            var service = serviceDto.MapToDomain();

            return await _servicesRepository.AddServiceAsync(service);
        }

        public async Task DeleteServiseAsync(int id)
        {
            await _servicesRepository.DeleteServiceAsync(id);
        }

        public async Task<ServicesDTO> GetServiseAsync(int id)
        {
            var service = await _servicesRepository.GetServiceAsync(id);

            var sercviceDto = service.MapToDto();

            sercviceDto.SupplierIds = await _servicesToSuppliersRepository.GetSupplierIdsOfServiceAsync(service.ServiseId);

            return sercviceDto;
        }

        public async Task<List<ServicesDTO>> GetServicesAsync()
        {
            var services = await _servicesRepository.GetServicesAsync();

            var serviceDtos = new List<ServicesDTO>();

            foreach (var service in services)
            {
                var serviceDto = service.MapToDto();
                serviceDto.SupplierIds = await _servicesToSuppliersRepository.GetSupplierIdsOfServiceAsync(service.ServiseId);

                serviceDtos.Add(serviceDto);
            }

            return serviceDtos;
        }

        public async Task<int> UpdateServiseAsync(ServicesDTO serviceDto) 
        {
            var service = serviceDto.MapToDomain();

            return await _servicesRepository.UpdateServiceAsync(service);
        }
    }
}
