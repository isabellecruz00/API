using System.Threading.Tasks;
using api_rest.Communication;
using api_rest.Domain.Models;
using System.Collections.Generic;

namespace api_rest.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        Task<IEnumerable<Category>> FindByNameAsync(string name);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
