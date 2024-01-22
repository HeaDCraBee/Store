using Store.Business.Mappers;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using Store.DAL.Repository.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Store
{
    public class ProductService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IProductsToSuppliersRepository _productsToSuppliersRepository;

        public ProductService(IProductsRepository productsRepository, IProductsToSuppliersRepository productsToSuppliersRepository)
        {
            _productsRepository = productsRepository;
            _productsToSuppliersRepository = productsToSuppliersRepository;
        }

        public async Task<int> AddProductAsync(ProductsDTO productDto)
        {
            var product = productDto.MapToDomain();

            return await _productsRepository.AddProductAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productsRepository.DeleteProductAsync(id);
        }

        public async Task<ProductsDTO> GetProductAsync(int id)
        {
            var product = await _productsRepository.GetProductAsync(id);

            var productDto = product.MapToDto();

            productDto.SupplierIds = await _productsToSuppliersRepository.GetSupplierIdsOfProductAsync(product.ProductId);

            return productDto;
        }

        public async Task<List<ProductsDTO>> GetProductsAsync()
        {
            var products = await _productsRepository.GetProductsAsync();

            var productDtos = new List<ProductsDTO>();

            foreach (var product in products) 
            {
                var productDto = product.MapToDto();
                productDto.SupplierIds = await _productsToSuppliersRepository.GetSupplierIdsOfProductAsync(product.ProductId);

                productDtos.Add(productDto);
            }

            return productDtos;
        }

        public async Task<int> UpdateProductAsync(ProductsDTO productDto)
        {
            var product = productDto.MapToDomain();

            return await _productsRepository.UpdateProductAsync(product);
        }
    }
}
