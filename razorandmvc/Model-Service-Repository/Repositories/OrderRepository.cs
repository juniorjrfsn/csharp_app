﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Core.Contexts;
using Microsoft.EntityFrameworkCore;
using Model_Service_Repository.Models;
using Model_Service_Repository.Repositories.Interfaces;

namespace Model_Service_Repository.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public Task<Order> GetByIdAsync(int id)
        {
            return _context.Orders.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
        }

        public void Update(Order entity)
        {
            _context.Orders.Update(entity);
        }

        public void Delete(Order entity)
        {
            _context.Orders.Remove(entity);
        }
    }
}