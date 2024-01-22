using Microsoft.AspNetCore.Mvc;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsToSuppliersController : ControllerBase
    {
        private readonly IProductsToSuppliersService _productsToSuppliersService;

        public ProductsToSuppliersController(IProductsToSuppliersService productsToSuppliersService)
        {
            _productsToSuppliersService = productsToSuppliersService;
        }

        [HttpGet]
        public async Task<List<ProductsToSuppliersDTO>> GetProductsToSuppliersAsync()
        {
            return await _productsToSuppliersService.GetProductsToSuppliersAsync();
        }

        [HttpGet("{id}")]
        public async Task<ProductsToSuppliersDTO> GetProductToSupplierAsync(int id)
        {
            return await _productsToSuppliersService.GetProductToSupplierAsync(id);
        }

        [HttpPost]
        public async Task<int> AddProductToSupplierAsync(ProductsToSuppliersDTO productToSupplierDTO)
        {
            return await _productsToSuppliersService.AddProductToSupplierAsync(productToSupplierDTO);
        }

        [HttpPut]
        public async Task<int> UpdateProductToSupplierAsync(ProductsToSuppliersDTO productToSupplierDTO)
        {
            return await _productsToSuppliersService.UpdateProductToSupplierAsync(productToSupplierDTO);
        }

        [HttpDelete]
        public async Task DeleteProductToSupplierAsync(int id)
        {
            await _productsToSuppliersService.DeleteProductToSupplierAsync(id);
        }
    }
}