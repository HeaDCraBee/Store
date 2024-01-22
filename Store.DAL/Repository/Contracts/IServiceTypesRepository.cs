using Store.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DAL.Repository.Contracts
{
    public interface IServiceTypesRepository
    {
        Task<ServiceTypes> GetServiceTypeAsync(int id);

        Task<List<ServiceTypes>> GetServiceTypesAsync();
    }
}
