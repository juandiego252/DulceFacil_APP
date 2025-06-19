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
    public interface IIncidenciaService
    {
        [OperationContract]
        Task AddIncidenciaAsync(Incidencia incidencia);

        [OperationContract]
        Task UpdateIncidenciaAsync(Incidencia incidencia);

        [OperationContract]
        Task DeleteIncidenciaAsync(int id);

        [OperationContract]
        Task<Incidencia> GetIncidenciaByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<Incidencia>> GetAllIncidenciasAsync();
    }
}
