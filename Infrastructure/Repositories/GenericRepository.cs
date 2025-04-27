using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SICT_ShowCaseContext _ShowCaseContext;

        public GenericRepository(SICT_ShowCaseContext showCaseContext)
        {
            _ShowCaseContext = showCaseContext;
        }

        public async Task AddAsync(T entity)
        {
            await _ShowCaseContext.Set<T>().AddAsync(entity);
        }

        public Task Delete(T entity)
        {
            _ShowCaseContext.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _ShowCaseContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _ShowCaseContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _ShowCaseContext.Set<T>().FindAsync(id);
        }

        public Task Update(T entity)
        {
            _ShowCaseContext.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}
