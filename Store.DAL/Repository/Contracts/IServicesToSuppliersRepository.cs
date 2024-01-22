using Store.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DAL.Repository.Contracts
{
    public interface IServicesToSuppliersRepository
    {
        Task<ServicesToSuppliers> GetServiceToSupplierAsync(int id);

        Task<List<ServicesToSuppliers>> GetServicesToSuppliersAsync();

        Task<List<int>> GetSupplierIdsOfServiceAsync(int serviceId);

        Task<List<int>> GetServiceIdsOfSupplierAsync(int supplierId);

        Task<int> AddServiceToSupplierAsync(ServicesToSuppliers serviceToSupplier);

        Task<int> UpdateServiceToSupplierAsync(ServicesToSuppliers serviceToSupplier);

        Task DeleteProductToSupplierAsync(int id);
    }
}
