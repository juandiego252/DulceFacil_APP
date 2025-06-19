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
    public interface IEstadoEntregaService
    {
        [OperationContract]
        Task AddEstadoEntregaAsync(EstadoEntrega estadoEntrega);

        [OperationContract]
        Task UpdateEstadoEntregaAsync(EstadoEntrega estadoEntrega);

        [OperationContract]
        Task DeleteEstadoEntregaAsync(int id);

        [OperationContract]
        Task<EstadoEntrega> GetEstadoEntregaByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<EstadoEntrega>> GetAllEstadosEntregaAsync();
    }
}
