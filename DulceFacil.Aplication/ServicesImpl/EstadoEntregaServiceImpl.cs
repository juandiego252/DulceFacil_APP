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
    public class EstadoEntregaServiceImpl : IEstadoEntregaService
    {
        private readonly IEstadoEntregaRepository _estadoEntregaRepository;

        public EstadoEntregaServiceImpl(DulceFacilContext context)
        {
            _estadoEntregaRepository = new EstadoEntregaRepositoryImpl(context);
        }
        public async Task AddEstadoEntregaAsync(EstadoEntrega estadoEntrega)
        {
            await _estadoEntregaRepository.AddAsync(estadoEntrega);
        }

        public async Task DeleteEstadoEntregaAsync(int id)
        {
            await _estadoEntregaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<EstadoEntrega>> GetAllEstadosEntregaAsync()
        {
            return await _estadoEntregaRepository.GetAllAsync();
        }

        public async Task<EstadoEntrega> GetEstadoEntregaByIdAsync(int id)
        {
            return await _estadoEntregaRepository.GetByIdAsync(id);
        }

        public async Task UpdateEstadoEntregaAsync(EstadoEntrega estadoEntrega)
        {
            await _estadoEntregaRepository.UpdateAsync(estadoEntrega);
        }
    }
}
