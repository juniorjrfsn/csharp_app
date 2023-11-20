using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Model_Service_Repository.Repositories.Interfaces
{
    public interface IRepository<TEntity>//, TContext>
        where TEntity : class
        //where TContext : DbContext
    {
        public Task SaveChangesAsync();
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<TEntity> GetByIdAsync(int id);
        public Task AddAsync(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
    }
}