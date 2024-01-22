using Store.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.DAL.Repository.Contracts
{
    public interface IProductsRepository
    {
        Task<Products> GetProductAsync(int id);

        Task<List<Products>> GetProductsAsync();

        Task<int> AddProductAsync(Products product);

        Task<int> UpdateProductAsync(Products product);

        Task DeleteProductAsync(int id);
    }
}
