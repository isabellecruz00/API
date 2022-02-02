using System.Threading.Tasks;
using api_rest.Domain.Models;
using api_rest.Domain.Helpers;
using api_rest.Domain.Services;
using System.Collections.Generic;
using api_rest.Domain.Repositories;

namespace api_rest.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
       
        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            return await _productRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Product>> FindByPlatformAsync(EUnitOfPlatform platform)
        {
            return await _productRepository.FindByPlatformAsync(platform);
        }

    }
}
