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
    public class ConductorServiceImpl : IConductorService
    {
        private readonly IConductorRepository _conductorRepository;

        public ConductorServiceImpl(DulceFacilContext context)
        {
            _conductorRepository = new ConductorRepositoryImpl(context);
        }
        public async Task AddConductorAsync(Conductor conductor)
        {
            await _conductorRepository.AddAsync(conductor);
        }

        public async Task DeleteConductorAsync(int idConductor)
        {
            await _conductorRepository.DeleteAsync(idConductor);
        }

        public async Task<IEnumerable<Conductor>> GetAllConductoresAsync()
        {
            return await _conductorRepository.GetAllAsync();
        }

        public async Task<Conductor> GetConductorByIdAsync(int idConductor)
        {
            return await _conductorRepository.GetByIdAsync(idConductor);
        }

        public async Task UpdateConductorAsync(Conductor conductor)
        {
            await _conductorRepository.UpdateAsync(conductor);
        }
    }
}
