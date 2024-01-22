using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Store.Contracts
{
    public interface IServicesService
    {
        Task<ServicesDTO> GetServiseAsync(int id);

        Task<List<ServicesDTO>> GetServicesAsync();

        Task<int> AddServiseAsync(ServicesDTO serviceDto);

        Task<int> UpdateServiseAsync(ServicesDTO serviceDto);

        Task DeleteServiseAsync(int id);
    }
}
