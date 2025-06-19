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
    public class RutaServiceImpl : IRutaService
    {
        private readonly IRutaRepository _rutaRepository;

        public RutaServiceImpl(DulceFacilContext context)
        {
            _rutaRepository = new RutaRepositoryImpl(context);
        }
        public async Task AddRutaAsync(Ruta ruta)
        {
            await _rutaRepository.AddAsync(ruta);
        }

        public async Task DeleteRutaAsync(int idRuta)
        {
            await _rutaRepository.DeleteAsync(idRuta);
        }

        public async Task<IEnumerable<Ruta>> GetAllRutasAsync()
        {
            return await _rutaRepository.GetAllAsync();
        }

        public async Task<Ruta> GetRutaByIdAsync(int idRuta)
        {
            return await _rutaRepository.GetByIdAsync(idRuta);
        }

        public async Task UpdateRutaAsync(Ruta ruta)
        {
            await _rutaRepository.UpdateAsync(ruta);
        }
    }
}
