using FluentValidationInAnAspNetCore.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FluentValidationInAnAspNetCore.Api.Controllers
{
    [Route("api/v1/customers")]
    public class CustomersController:Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomersController(ICustomerRepository customerRepository) =>
            _customerRepository = customerRepository;


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _customerRepository.GetAsync();
            return Ok(data);
        }
    }
}
