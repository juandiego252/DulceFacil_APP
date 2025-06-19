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
    public class IncidenciaServiceImpl : IIncidenciaService
    {
        private readonly IIncidenciaRepository _incidenciaRepository;

        public IncidenciaServiceImpl(DulceFacilContext context)
        {
            _incidenciaRepository = new IncidenciaRepositoryImpl(context);
        }

        public async Task AddIncidenciaAsync(Incidencia incidencia)
        {
            await _incidenciaRepository.AddAsync(incidencia);
        }

        public async Task DeleteIncidenciaAsync(int id)
        {
            await _incidenciaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Incidencia>> GetAllIncidenciasAsync()
        {
            return await _incidenciaRepository.GetAllAsync();
        }

        public async Task<Incidencia> GetIncidenciaByIdAsync(int id)
        {
            return await _incidenciaRepository.GetByIdAsync(id);
        }

        public async Task UpdateIncidenciaAsync(Incidencia incidencia)
        {
            await _incidenciaRepository.UpdateAsync(incidencia);
        }
    }
}
