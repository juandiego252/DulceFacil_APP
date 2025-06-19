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
    public class DireccionServiceImpl : IDireccionService
    {
        private readonly IDireccionRepository _direccionRepository;

        public DireccionServiceImpl(DulceFacilContext context)
        {
            _direccionRepository = new DireccionRepositoryImpl(context);
        }
        public async Task AddDireccionAsync(Direccion direccion)
        {
            await _direccionRepository.AddAsync(direccion);
        }

        public async Task DeleteDireccionAsync(int idDireccion)
        {
            await _direccionRepository.DeleteAsync(idDireccion);
        }

        public async Task<IEnumerable<Direccion>> GetAllDireccionAsync()
        {
            return await _direccionRepository.GetAllAsync();
        }

        public async Task<Direccion> GetDireccionByIdAsync(int idDireccion)
        {
            return await _direccionRepository.GetByIdAsync(idDireccion);
        }

        public async Task UpdateDireccionAsync(Direccion direccion)
        {
            await _direccionRepository.UpdateAsync(direccion);
        }
    }
}
