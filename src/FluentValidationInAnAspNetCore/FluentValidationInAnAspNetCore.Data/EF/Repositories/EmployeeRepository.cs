using FluentValidationInAnAspNetCore.Domain.Contracts.Repositories;
using FluentValidationInAnAspNetCore.Domain.Entities;

namespace FluentValidationInAnAspNetCore.Data.EF.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(StoreDataContext ctx) : base(ctx)
        { }
    }
}
