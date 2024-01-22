using Store.Business.Mappers;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using Store.DAL.Repository.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Business.Store
{
    public class ServicesToSuppliersService : IServicesToSuppliersService
    {
        private readonly IServicesToSuppliersRepository _servicesToSuppliersRepository;

        public ServicesToSuppliersService(IServicesToSuppliersRepository servicesToSuppliersRepository)
        {
            _servicesToSuppliersRepository = servicesToSuppliersRepository;
        }

        public async Task<int> AddServiceToSupplierAsync(ServicesToSuppliersDTO serviceToSupplierDTO)
        {
            var serviceToSupplier = serviceToSupplierDTO.MapToDomain();

            return await _servicesToSuppliersRepository.AddServiceToSupplierAsync(serviceToSupplier);
        }

        public async Task DeleteServiceToSupplierAsync(int id)
        {
            await _servicesToSuppliersRepository.DeleteProductToSupplierAsync(id);
        }

        public async Task<List<ServicesToSuppliersDTO>> GetServicesToSuppliersAsync()
        {
            var servicesToSuppliers = await _servicesToSuppliersRepository.GetServicesToSuppliersAsync();

            return servicesToSuppliers.Select(x => x.MapToDto()).ToList();
        }

        public async Task<ServicesToSuppliersDTO> GetServiceToSupplierAsync(int id)
        {
            var serviceToSupplier = await _servicesToSuppliersRepository.GetServiceToSupplierAsync(id);

            return serviceToSupplier.MapToDto();
        }

        public async Task<int> UpdateServiceToSupplierAsync(ServicesToSuppliersDTO serviceToSupplierDTO)
        {
            var serviceToSupplier = serviceToSupplierDTO.MapToDomain();

            return await _servicesToSuppliersRepository.UpdateServiceToSupplierAsync(serviceToSupplier);
        }
    }
}
