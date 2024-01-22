using Store.Business.Mappers;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using Store.DAL.Repository.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Business.Store
{
    public class SuppliersService : ISuppliersService
    {
        private readonly ISuppliersRepository _suppliersRepository;
        private readonly IProductsToSuppliersRepository _productsToSuppliersRepository;
        private readonly IServicesToSuppliersRepository _servicesToSuppliersRepository;

        public SuppliersService(ISuppliersRepository suppliersRepository, IProductsToSuppliersRepository productsToSuppliersRepository, IServicesToSuppliersRepository servicesToSuppliersRepository)
        {
            _suppliersRepository = suppliersRepository;
            _productsToSuppliersRepository = productsToSuppliersRepository;
            _servicesToSuppliersRepository = servicesToSuppliersRepository;
        }

        public async Task<int> AddSupplierAsync(SuppliersDTO supplierDto) 
        {
            var supplier = supplierDto.MapToDomain();

            return await _suppliersRepository.AddSupplierAsync(supplier);
        }

        public async Task DeleteSupplierAsync(int id)
        {
            await _suppliersRepository.DeleteSupplierAsync(id);
        }

        public async Task<SuppliersDTO> GetSupplierAsync(int id) 
        {
            var supplier = await _suppliersRepository.GetSupplierAsync(id);

            var supplierDto = supplier.MapToDto();

            supplierDto.ProductIds = await _productsToSuppliersRepository.GetProductIdsOfSupplierAsync(supplier.SupplierId);
            supplierDto.ServiceIds = await _servicesToSuppliersRepository.GetServiceIdsOfSupplierAsync(supplier.SupplierId);

            return supplierDto;
        }

        public async Task<List<SuppliersDTO>> GetSuppliersAsync() 
        {
            var suppliers = await _suppliersRepository.GetSuppliersAsync();

            var supplierDtos = new List<SuppliersDTO>();

            foreach (var supplier in suppliers)
            {
                var supplierDto = supplier.MapToDto();
                supplierDto.ProductIds = await _productsToSuppliersRepository.GetProductIdsOfSupplierAsync(supplier.SupplierId);
                supplierDto.ServiceIds = await _servicesToSuppliersRepository.GetServiceIdsOfSupplierAsync(supplier.SupplierId);

                supplierDtos.Add(supplierDto);
            }

            return suppliers.Select(x => x.MapToDto()).ToList();
        }

        public async Task<int> UpdateSupplierAsync(SuppliersDTO supplierDto) 
        {
            var supplier = supplierDto.MapToDomain();

            return await _suppliersRepository.UpdateSupplierAsync(supplier);
        }
    }
}
