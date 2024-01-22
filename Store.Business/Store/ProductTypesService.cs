using Store.Business.Mappers;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using Store.DAL.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Store.Business.Store
{
    public class ProductTypesService : IProductTypesService
    {
        private readonly IProductTypesRepository _productTypesRepository;

        public ProductTypesService(IProductTypesRepository productTypesRepository)
        {
            _productTypesRepository = productTypesRepository;
        }

        public async Task<ProductTypesDTO> GetProductTypeAsync(int id)
        {
            var productType = await _productTypesRepository.GetProductTypeAsync(id);

            return productType.MapToDto();
        }

        public async Task<List<ProductTypesDTO>> GetProductTypesAsync()
        {
            var productTypes = await _productTypesRepository.GetProductTypesAsync();

            return productTypes.Select(x => x.MapToDto()).ToList();
        }
    }
}
