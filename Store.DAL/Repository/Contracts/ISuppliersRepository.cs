using Store.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DAL.Repository.Contracts
{
    public interface ISuppliersRepository
    {
        Task<Suppliers> GetSupplierAsync(int id);

        Task<List<Suppliers>> GetSuppliersAsync();

        Task<int> AddSupplierAsync(Suppliers supplier);

        Task<int> UpdateSupplierAsync(Suppliers supplier);

        Task DeleteSupplierAsync(int id);
    }
}
