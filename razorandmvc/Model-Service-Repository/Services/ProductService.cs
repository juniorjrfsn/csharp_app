using System.Collections.Generic;
using System.Threading.Tasks;
using Model_Service_Repository.Models;
using Model_Service_Repository.Repositories.Interfaces;
using Model_Service_Repository.Services.Interfaces;

namespace Model_Service_Repository.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task AddAsync(Product entity)
        {
            await _repo.AddAsync(entity);
            await _repo.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product entity)
        {
            _repo.Update(entity);
            await _repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product entity)
        {
            _repo.Delete(entity);
            await _repo.SaveChangesAsync();
        }
    }
}