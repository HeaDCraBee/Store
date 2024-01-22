using Microsoft.AspNetCore.Mvc;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public async Task<List<ProductsDTO>> GetProductsAsync()
        {
            return await _productsService.GetProductsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ProductsDTO> GetProductAsync(int id)
        {
            return await _productsService.GetProductAsync(id);
        }

        [HttpPost]
        public async Task<int> AddProductAsync(ProductsDTO productDTO)
        {
            return await _productsService.AddProductAsync(productDTO);
        }

        [HttpPut]
        public async Task<int> UpdateProductAsync(ProductsDTO productDTO)
        {
            return await _productsService.UpdateProductAsync(productDTO);
        }

        [HttpDelete]
        public async Task DeleteProductAsync(int id)
        {
            await _productsService.DeleteProductAsync(id);
        }
    }
}
