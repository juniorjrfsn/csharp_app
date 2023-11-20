using System.Collections.Generic;
using System.Threading.Tasks;

namespace Model_Service_Repository.Services.Interfaces
{
    public interface IService<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}