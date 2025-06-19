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
    public interface IRutaService
    {
        [OperationContract]
        Task AddRutaAsync(Ruta ruta);

        [OperationContract]
        Task UpdateRutaAsync(Ruta ruta);

        [OperationContract]
        Task DeleteRutaAsync(int idRuta);

        [OperationContract]
        Task<Ruta> GetRutaByIdAsync(int idRuta);

        [OperationContract]
        Task<IEnumerable<Ruta>> GetAllRutasAsync();

    }
}
