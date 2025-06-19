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
    public interface IEntregaService
    {
        [OperationContract]
        Task AddEntregaAsync(Entrega entrega);

        [OperationContract]
        Task UpdateEntregaAsync(Entrega entrega);

        [OperationContract]
        Task DeleteEntregaAsync(int id);

        [OperationContract]
        Task<Entrega> GetEntregaByIdAsync(int id);

        [OperationContract]
        Task<IEnumerable<Entrega>> GetAllEntregasAsync();

    }
}
