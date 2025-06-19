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
    public class EntregaServiceImpl : IEntregaService
    {
        private readonly IEntregaRepository _entregaRepository;

        public EntregaServiceImpl(DulceFacilContext context)
        {
            _entregaRepository = new EntregaRepositoryImpl(context);
        }
        public async Task AddEntregaAsync(Entrega entrega)
        {
            await _entregaRepository.AddAsync(entrega);
        }

        public async Task DeleteEntregaAsync(int id)
        {
            await _entregaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Entrega>> GetAllEntregasAsync()
        {
            return await _entregaRepository.GetAllAsync();
        }

        public async Task<Entrega> GetEntregaByIdAsync(int id)
        {
            return await _entregaRepository.GetByIdAsync(id);
        }

        public async Task UpdateEntregaAsync(Entrega entrega)
        {
            await _entregaRepository.UpdateAsync(entrega);
        }
    }
}
