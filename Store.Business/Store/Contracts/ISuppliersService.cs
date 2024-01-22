using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Store.Contracts
{
    public interface ISuppliersService
    {
        Task<SuppliersDTO> GetSupplierAsync(int id);

        Task<List<SuppliersDTO>> GetSuppliersAsync();

        Task<int> AddSupplierAsync(SuppliersDTO supplierDto);

        Task<int> UpdateSupplierAsync(SuppliersDTO supplierDto);

        Task DeleteSupplierAsync(int id);
    }
}
