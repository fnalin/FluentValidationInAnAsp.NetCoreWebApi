using FluentValidationInAnAspNetCore.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FluentValidationInAnAspNetCore.Api.Controllers
{
    [Route("api/v1/employees")]
    public class EmployeesController: Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository) =>
            _employeeRepository = employeeRepository;


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _employeeRepository.GetAsync();
            return Ok(data);
        }
    }
}
