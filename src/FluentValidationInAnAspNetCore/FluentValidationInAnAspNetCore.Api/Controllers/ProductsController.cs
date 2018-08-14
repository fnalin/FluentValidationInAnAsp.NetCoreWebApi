using FluentValidationInAnAspNetCore.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FluentValidationInAnAspNetCore.Api.Controllers
{
    [Route("api/v1/products")]
    public class ProductsController: Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository) =>
            _productRepository = productRepository;


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _productRepository.GetAsync();
            return Ok(data);
        }

    }
}
