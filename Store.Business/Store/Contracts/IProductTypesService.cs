using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Store.Contracts
{
    public interface IProductTypesService
    {
        Task<ProductTypesDTO> GetProductTypeAsync(int id);

        Task<List<ProductTypesDTO>> GetProductTypesAsync();
    }
}
