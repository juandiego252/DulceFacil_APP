using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacil.Aplication.Services;
using DulceFacil.Domain.Models.Abstractions;
using DulceFacil.Domain.Models.Entities;
using DulceFacil.Infraestructure.DataAccess.DataEFCore;
using DulceFacil.Infraestructure.DataAccess.Repository;

namespace DulceFacil.Aplication.ServicesImpl
{
    public class ClienteServiceImpl : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteServiceImpl(DulceFacilContext context)
        {
            _clienteRepository = new ClienteRepositoryImpl(context);
        }
        public async Task AddClienteAsync(Cliente cliente)
        {
            await _clienteRepository.AddAsync(cliente);
        }

        public async Task DeleteClienteAsync(int idCliente)
        {
            await _clienteRepository.DeleteAsync(idCliente);
        }

        public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }

        public async Task<Cliente> GetClienteByIdAsync(int idCliente)
        {
            return await _clienteRepository.GetByIdAsync(idCliente);
        }

        public async Task UpdateClienteAsync(Cliente cliente)
        {
            await _clienteRepository.UpdateAsync(cliente);
        }
    }
}
