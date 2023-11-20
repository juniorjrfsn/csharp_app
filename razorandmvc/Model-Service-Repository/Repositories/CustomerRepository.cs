using System.Collections.Generic;
using System.Threading.Tasks;
using ecommerce.Core.Contexts;
using Microsoft.EntityFrameworkCore;
using Model_Service_Repository.Models;
using Model_Service_Repository.Repositories.Interfaces;

namespace Model_Service_Repository.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddAsync(Customer entity)
        {
            await _context.Customers.AddAsync(entity);
        }

        public void Update(Customer entity)
        {
            _context.Customers.Update(entity);
        }

        public void Delete(Customer entity)
        {
            _context.Customers.Remove(entity);
        }
    }
}