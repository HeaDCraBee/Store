using Store.Business.Mappers;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using Store.DAL.Repository.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Business.Store
{
    public class ProductsToSuppliersService : IProductsToSuppliersService
    {
        private readonly IProductsToSuppliersRepository _productsToSuppliersRepository;

        public ProductsToSuppliersService(IProductsToSuppliersRepository productsToSuppliersRepository)
        {
            _productsToSuppliersRepository = productsToSuppliersRepository;
        }

        public async Task<int> AddProductToSupplierAsync(ProductsToSuppliersDTO productToSupplierDto)
        {
            var productToSupplier = productToSupplierDto.MapToDomain();

            return await _productsToSuppliersRepository.AddProductToSupplierAsync(productToSupplier);
        }

        public async Task DeleteProductToSupplierAsync(int id)
        {
            await _productsToSuppliersRepository.DeleteProductToSupplierAsync(id);
        }

        public async Task<List<ProductsToSuppliersDTO>> GetProductsToSuppliersAsync()
        {
            var productsToSuppliers = await _productsToSuppliersRepository.GetProductsToSuppliersAsync();

            return productsToSuppliers.Select(x => x.MapToDto()).ToList();
        }

        public async Task<ProductsToSuppliersDTO> GetProductToSupplierAsync(int id)
        {
            var productToSupplier = await _productsToSuppliersRepository.GetProductToSupplierAsync(id);

            return productToSupplier.MapToDto();
        }

        public async Task<int> UpdateProductToSupplierAsync(ProductsToSuppliersDTO productToSupplierDto)
        {
            var productToSupplier = productToSupplierDto.MapToDomain();

            return await _productsToSuppliersRepository.UpdateProductToSupplierAsync(productToSupplier);
        }
    }
}
