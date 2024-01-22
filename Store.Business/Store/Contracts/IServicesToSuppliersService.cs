using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Store.Contracts
{
    public interface IServicesToSuppliersService
    {
        Task<ServicesToSuppliersDTO> GetServiceToSupplierAsync(int id);

        Task<List<ServicesToSuppliersDTO>> GetServicesToSuppliersAsync();

        Task<int> AddServiceToSupplierAsync(ServicesToSuppliersDTO serviceToSupplierDTO);

        Task<int> UpdateServiceToSupplierAsync(ServicesToSuppliersDTO serviceToSupplierDTO);

        Task DeleteServiceToSupplierAsync(int id);
    }
}
