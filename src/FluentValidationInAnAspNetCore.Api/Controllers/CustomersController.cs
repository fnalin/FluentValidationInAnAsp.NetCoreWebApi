using FluentValidationInAnAspNetCore.Api.Models;
using FluentValidationInAnAspNetCore.Domain.Contracts.Repositories;
using FluentValidationInAnAspNetCore.Domain.Entities;
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

        [HttpGet("{id}", Name = "CustomerGet")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _customerRepository.GetAsync(id);

            if (data == null) return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post([FromBody]NewCustomer newCustomer)
        {
            var customer = new Customer(newCustomer.Name, newCustomer.City);

            _customerRepository.Add(customer);

            var url = Url.Link("CustomerGet", new { id = customer.Id });
            return Created(url, customer);
        }

    }
}
