using Microsoft.AspNetCore.Mvc;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypesService _productTypesService;

        public ProductTypesController(IProductTypesService productTypesService)
        {
            _productTypesService = productTypesService;
        }

        [HttpGet]
        public async Task<List<ProductTypesDTO>> GetProductTypesAsync()
        {
            return await _productTypesService.GetProductTypesAsync();
        }

        [HttpGet("{id}")]
        public async Task<ProductTypesDTO> GetProductTypeAsync(int id)
        {
            return await _productTypesService.GetProductTypeAsync(id);
        }
    }
}
