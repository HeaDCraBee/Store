using Store.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DAL.Repository.Contracts
{
    public interface IProductsToSuppliersRepository
    {
        Task<ProductsToSuppliers> GetProductToSupplierAsync(int id);

        Task<List<ProductsToSuppliers>> GetProductsToSuppliersAsync();

        Task<List<int>> GetSupplierIdsOfProductAsync(int productId);

        Task<List<int>> GetProductIdsOfSupplierAsync(int supplierId);

        Task<int> AddProductToSupplierAsync(ProductsToSuppliers service);

        Task<int> UpdateProductToSupplierAsync(ProductsToSuppliers service);

        Task DeleteProductToSupplierAsync(int id);
    }
}
