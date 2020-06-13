using Dashboard.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Shared.DAL.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> AddProductAsync(Product product);
        Task<Product> EditProductAsync(Product product);
        Task<bool> DeleteProductAsync(int productId);
        Task<IEnumerable<Product>> GetProductAsync();
        Task<IEnumerable<Product>> GetProductAsync(int branchId);
        Task<bool> IsAvailable(int productId);
    }
}
