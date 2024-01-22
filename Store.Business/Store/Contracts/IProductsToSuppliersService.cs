using Store.Business.Store.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Store.Contracts
{
    public interface IProductsToSuppliersService
    {
        Task<ProductsToSuppliersDTO> GetProductToSupplierAsync(int id);

        Task<List<ProductsToSuppliersDTO>> GetProductsToSuppliersAsync();

        Task<int> AddProductToSupplierAsync(ProductsToSuppliersDTO productToSupplierDto);

        Task<int> UpdateProductToSupplierAsync(ProductsToSuppliersDTO productToSupplierDto);

        Task DeleteProductToSupplierAsync(int id);
    }
}
