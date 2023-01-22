using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Strategy.csproj.Models;

namespace WebApp.Strategy.Reporsitories
{
    public interface IProductRepository
    {
        Task<Product> GetById(string id);
        Task<List<Product>> GetAllByUserId(string userId);
        Task<Product> Save(Product product);
        Task Update(Product product);
        Task Delete(Product product);

    }
}
