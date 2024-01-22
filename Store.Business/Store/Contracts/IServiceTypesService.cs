using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Store.Contracts
{
    public interface IServiceTypesService
    {
        Task<ServiceTypesDTO> GetServiceTypeAsync(int id);

        Task<List<ServiceTypesDTO>> GetServiceTypesAsync();
    }
}
