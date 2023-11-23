using RepositoryServicePatternDemo.Core.Models;
using RepositoryServicePatternDemo.Core.Repositories;
using System.Collections.Generic;

namespace RepositoryServicePatternDemo.Core.Services
{
    public class IClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepo;

        public IClienteService(IClienteRepository clienteRepo)
        {
            _clienteRepo = clienteRepo;
        }

        public List<Cliente> GetAllSold() => _clienteRepo.GetAllSold();
    }
}
