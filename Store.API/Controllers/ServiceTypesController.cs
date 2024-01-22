using Microsoft.AspNetCore.Mvc;
using Store.Business.Store;
using Store.Business.Store.Contracts;
using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceTypesController : ControllerBase
    {
        private readonly IServiceTypesService _serviceTypesService;

        public ServiceTypesController(IServiceTypesService serviceTypesService)
        {
            _serviceTypesService = serviceTypesService;
        }

        [HttpGet]
        public async Task<List<ServiceTypesDTO>> GetServiceTypesAsync()
        {
            return await _serviceTypesService.GetServiceTypesAsync();
        }

        [HttpGet("{id}")]
        public async Task<ServiceTypesDTO> GetServiceTypeAsync(int id)
        {
            return await _serviceTypesService.GetServiceTypeAsync(id);
        }
    }
}
