using AutoMapper;
using api_rest.Resources;
using System.Threading.Tasks;
using api_rest.Domain.Models;
using api_rest.Domain.Helpers;
using api_rest.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace api_rest.Controllers
{
    [Route("/api/product")]
    [Authorize()]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductResource>> ListAsync()
        {
            var products = await _productService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>>(products);

            return resources;
        }

        [HttpGet("{id}")]
        public async Task<ProductResource> FindByIdAsync(int id)
        {
            var products = await _productService.FindByIdAsync(id);
            var resources = _mapper.Map<Product,ProductResource>(products);

            return resources;
        }

        [HttpGet("platform")]
        public async Task<IEnumerable<ProductResource>> FindByPlatformAsync(EUnitOfPlatform platfortm)
        {
            var products = await _productService.FindByPlatformAsync(platfortm);
            var resources = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>>(products);

            return resources;
        }
    }
}
