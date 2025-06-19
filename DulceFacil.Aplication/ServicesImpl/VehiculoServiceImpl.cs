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
    public class VehiculoServiceImpl : IVehiculoService
    {
        private readonly IVehiculoRepository _vehiculoRepository;

        public VehiculoServiceImpl(DulceFacilContext context)
        {
            _vehiculoRepository = new VehiculoRepositoryImpl(context);
        }
        public async Task AddVehiculoAsync(Vehiculo vehiculo)
        {
            await _vehiculoRepository.AddAsync(vehiculo);
        }

        public async Task DeleteVehiculoAsync(int vehiculoId)
        {
            await _vehiculoRepository.DeleteAsync(vehiculoId);
        }

        public async Task<IEnumerable<Vehiculo>> GetAllVehiculosAsync()
        {
            return await _vehiculoRepository.GetAllAsync();
        }

        public async Task<Vehiculo> GetVehiculoByIdAsync(int vehiculoId)
        {
            return await _vehiculoRepository.GetByIdAsync(vehiculoId);
        }

        public async Task UpdateVehiculoAsync(Vehiculo vehiculo)
        {
            await _vehiculoRepository.UpdateAsync(vehiculo);
        }
    }
}
