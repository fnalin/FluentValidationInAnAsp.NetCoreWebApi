using FluentValidationInAnAspNetCore.Domain.Contracts.Repositories;
using FluentValidationInAnAspNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FluentValidationInAnAspNetCore.Data.EF.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly StoreDataContext _ctx;

        public Repository(StoreDataContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);
            save();
        }

        public void Delete(T entity)
        {
            _ctx.Set<T>().Remove(entity);
            save();
        }

        public IEnumerable<T> Get()
        {
            return _ctx.Set<T>().AsNoTracking();
        }

        public T Get(object Id)
        {
            return _ctx.Set<T>().Find(Id);
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _ctx.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetAsync(object Id)
        {
            return await _ctx.Set<T>().FindAsync(Id);
        }

        public void Update(T entity)
        {
            entity.LastUpdatedOn = System.DateTime.UtcNow;
            _ctx.Entry(entity).State = EntityState.Modified;
            save();
        }

        private void save()
        {
            //todo aplicar UoW
            _ctx.SaveChanges();
        }

    }
}
