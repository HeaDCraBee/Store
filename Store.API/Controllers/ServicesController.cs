using Microsoft.AspNetCore.Mvc;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServicesService _servicesService;

        public ServicesController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        [HttpGet]
        public async Task<List<ServicesDTO>> GetServicesAsync()
        {
            return await _servicesService.GetServicesAsync();
        }

        [HttpGet("{id}")]
        public async Task<ServicesDTO> GetServiseAsync(int id)
        {
            return await _servicesService.GetServiseAsync(id);
        }

        [HttpPost]
        public async Task<int> AddServiseAsync(ServicesDTO serviceDTO)
        {
            return await _servicesService.AddServiseAsync(serviceDTO);
        }

        [HttpPut]
        public async Task<int> UpdateServiseAsync(ServicesDTO serviceDTO)
        {
            return await _servicesService.UpdateServiseAsync(serviceDTO);
        }

        [HttpDelete]
        public async Task DeleteServiseAsync(int id)
        {
            await _servicesService.DeleteServiseAsync(id);
        }
    }
}
