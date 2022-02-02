using System.Threading.Tasks;
using api_rest.Domain.Models;
using System.Collections.Generic;

namespace api_rest.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        Task<IEnumerable<Category>> FindByNameAsync(string name);
        void Update(Category category);
        void Remove(Category category);
    }
}
