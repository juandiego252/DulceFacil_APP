using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DulceFacil.Domain.Models.Entities;

namespace DulceFacil.Aplication.Services
{
    [ServiceContract]
    public interface IVehiculoService
    {
        [OperationContract]
        Task AddVehiculoAsync(Vehiculo vehiculo);

        [OperationContract]
        Task UpdateVehiculoAsync(Vehiculo vehiculo);

        [OperationContract]
        Task DeleteVehiculoAsync(int vehiculoId);

        [OperationContract]
        Task<Vehiculo> GetVehiculoByIdAsync(int vehiculoId);

        [OperationContract]
        Task<IEnumerable<Vehiculo>> GetAllVehiculosAsync();

    }
}
