using System.Collections.Generic;
using System.Threading.Tasks;
using Model_Service_Repository.Models;
using Model_Service_Repository.Repositories.Interfaces;
using Model_Service_Repository.Services.Interfaces;

namespace Model_Service_Repository.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;

        public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task AddAsync(Order entity)
        {
            await _repo.AddAsync(entity);
            await _repo.SaveChangesAsync();
        }

        public async Task UpdateAsync(Order entity)
        {
            _repo.Update(entity);
            await _repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Order entity)
        {
            _repo.Delete(entity);
            await _repo.SaveChangesAsync();
        }
    }
}