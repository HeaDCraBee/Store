using Microsoft.AspNetCore.Mvc;
using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Business.Store.Contracts;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController: ControllerBase
    {
        private readonly ISuppliersService _suppliersService;

        public SuppliersController(ISuppliersService suppliersService)
        {
            _suppliersService = suppliersService;
        }

        [HttpGet]
        public async Task<List<SuppliersDTO>> GetSuppliersAsync()
        {
            return await _suppliersService.GetSuppliersAsync();
        }

        [HttpGet("{id}")]
        public async Task<SuppliersDTO> GetSupplierAsync(int id)
        {
            return await _suppliersService.GetSupplierAsync(id);
        }


        [HttpPost]
        public async Task<int> AddSupplierAsync(SuppliersDTO supplierDTO)
        {
            return await _suppliersService.AddSupplierAsync(supplierDTO);
        }

        [HttpPut]
        public async Task<int> UpdateSupplierAsync(SuppliersDTO supplierDTO)
        {
            return await _suppliersService.UpdateSupplierAsync(supplierDTO);
        }

        [HttpDelete]
        public async Task DeleteSupplierAsync(int id)
        {
            await _suppliersService.DeleteSupplierAsync(id);
        }
    }
}
