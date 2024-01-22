using Store.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DAL.Repository.Contracts
{
    public interface IServicesRepository
    {
        Task<Services> GetServiceAsync(int id);

        Task<List<Services>> GetServicesAsync();

        Task<int> AddServiceAsync(Services service);

        Task<int> UpdateServiceAsync(Services service);

        Task DeleteServiceAsync(int id);
    }
}
