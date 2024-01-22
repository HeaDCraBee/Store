using Store.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DAL.Repository.Contracts
{
    public interface IProductTypesRepository
    {
        Task<ProductTypes> GetProductTypeAsync(int i);

        Task<List<ProductTypes>> GetProductTypesAsync();
    }
}
