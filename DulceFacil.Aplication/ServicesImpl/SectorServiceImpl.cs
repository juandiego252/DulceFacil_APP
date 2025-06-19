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
    public class SectorServiceImpl : ISectorService
    {
        private readonly ISectorRepository _sectorRepository;

        public SectorServiceImpl(DulceFacilContext context)
        {
            _sectorRepository = new SectorRepositoryImpl(context);
        }
        public async Task AddSectorAsync(Sector sector)
        {
            await _sectorRepository.AddAsync(sector);
        }

        public async Task DeleteSectorAsync(int sectorId)
        {
            await _sectorRepository.DeleteAsync(sectorId);
        }

        public async Task<IEnumerable<Sector>> GetAllSectorsAsync()
        {
            return await _sectorRepository.GetAllAsync();
        }

        public async Task<Sector> GetSectorByIdAsync(int sectorId)
        {
            return await _sectorRepository.GetByIdAsync(sectorId);
        }

        public async Task UpdateSectorAsync(Sector sector)
        {
            await _sectorRepository.UpdateAsync(sector);
        }
    }
}
