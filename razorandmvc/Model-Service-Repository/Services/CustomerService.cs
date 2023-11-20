using System.Collections.Generic;
using System.Threading.Tasks;
using Model_Service_Repository.Models;
using Model_Service_Repository.Repositories.Interfaces;
using Model_Service_Repository.Services.Interfaces;

namespace Model_Service_Repository.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task AddAsync(Customer entity)
        {
            await _repo.AddAsync(entity);
            await _repo.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer entity)
        {
            _repo.Update(entity);
            await _repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Customer entity)
        {
            _repo.Delete(entity);
            await _repo.SaveChangesAsync();
        }
    }
}