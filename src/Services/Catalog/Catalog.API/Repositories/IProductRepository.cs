using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.API.Model;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> GetProductbyName(string name);
        Task<IEnumerable<Product>> GetProductbyCategory(string categoryName);

        Task CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);

        Task<bool> DeleteProduct(string id);

    }
}
