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
    public interface IClienteService
    {
        [OperationContract]
        Task AddClienteAsync(Cliente cliente);

        [OperationContract]
        Task UpdateClienteAsync(Cliente cliente);

        [OperationContract]
        Task DeleteClienteAsync(int idCliente);

        [OperationContract]
        Task<Cliente> GetClienteByIdAsync(int idCliente);

        [OperationContract]
        Task<IEnumerable<Cliente>> GetAllClientesAsync();

    }
}
