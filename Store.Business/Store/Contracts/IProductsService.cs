using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Store.Contracts
{
    public interface IProductsService
    {
        Task<ProductsDTO> GetProductAsync(int id);

        Task<List<ProductsDTO>> GetProductsAsync();

        Task<int> AddProductAsync(ProductsDTO productDto);

        Task<int> UpdateProductAsync(ProductsDTO productDto);

        Task DeleteProductAsync(int id);
    }
}
