using FluentValidationInAnAspNetCore.Domain.Contracts.Repositories;
using FluentValidationInAnAspNetCore.Domain.Entities;

namespace FluentValidationInAnAspNetCore.Data.EF.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(StoreDataContext ctx) : base(ctx)
        { }
    }
}
