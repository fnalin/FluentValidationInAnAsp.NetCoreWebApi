using FluentValidationInAnAspNetCore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FluentValidationInAnAspNetCore.Domain.Contracts.Repositories
{
    public interface IRepository<T>
        where T : Entity
    {

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        IEnumerable<T> Get();
        Task<IEnumerable<T>> GetAsync();

        T Get(object Id);
        Task<T> GetAsync(object Id);

    }
}
