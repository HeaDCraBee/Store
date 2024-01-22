using Microsoft.AspNetCore.Mvc;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesToSuppliersController : ControllerBase
    {
        private readonly IServicesToSuppliersService _servicesToSuppliersService;

        public ServicesToSuppliersController(IServicesToSuppliersService servicesToSuppliersService)
        {
            _servicesToSuppliersService = servicesToSuppliersService;
        }

        [HttpGet]
        public async Task<List<ServicesToSuppliersDTO>> GetProductsToSuppliersAsync()
        {
            return await _servicesToSuppliersService.GetServicesToSuppliersAsync();
        }

        [HttpGet("{id}")]
        public async Task<ServicesToSuppliersDTO> GetProductToSupplierAsync(int id)
        {
            return await _servicesToSuppliersService.GetServiceToSupplierAsync(id);
        }

        [HttpPost]
        public async Task<int> AddServiceToSupplierAsync(ServicesToSuppliersDTO servicesToSuppliersDTO)
        {
            return await _servicesToSuppliersService.AddServiceToSupplierAsync(servicesToSuppliersDTO);
        }

        [HttpPut]
        public async Task<int> UpdateServiceToSupplierAsync(ServicesToSuppliersDTO servicesToSuppliersDTO)
        {
            return await _servicesToSuppliersService.UpdateServiceToSupplierAsync(servicesToSuppliersDTO);
        }

        [HttpDelete]
        public async Task DeleteServiceToSupplierAsync(int id)
        {
            await _servicesToSuppliersService.DeleteServiceToSupplierAsync(id);
        }
    }
}