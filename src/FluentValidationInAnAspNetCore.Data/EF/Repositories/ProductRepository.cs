using FluentValidationInAnAspNetCore.Domain.Contracts.Repositories;
using FluentValidationInAnAspNetCore.Domain.Entities;

namespace FluentValidationInAnAspNetCore.Data.EF.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(StoreDataContext ctx) : base(ctx)
        {}
    }
}
