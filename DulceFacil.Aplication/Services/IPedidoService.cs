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
    public interface IPedidoService
    {
        [OperationContract]
        Task AddPedidoAsync(Pedido pedido);

        [OperationContract]
        Task UpdatePedidoAsync(Pedido pedido);

        [OperationContract]
        Task DeletePedidoAsync(int idPedido);
        [OperationContract]
        Task<Pedido> GetPedidoByIdAsync(int idPedido);

        [OperationContract]
        Task<IEnumerable<Pedido>> GetAllPedidosAsync();
    }
}
