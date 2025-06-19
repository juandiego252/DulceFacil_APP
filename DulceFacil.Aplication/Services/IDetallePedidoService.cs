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
    public interface IDetallePedidoService
    {
        [OperationContract]
        Task AddDetallePedidoAsync(DetallePedido detallePedido);

        [OperationContract]
        Task UpdateDetallePedidoAsync(DetallePedido detallePedido);

        [OperationContract]
        Task DeleteDetallePedidoAsync(int idDetallePedido);

        [OperationContract]
        Task<DetallePedido> GetDetallePedidoByIdAsync(int idDetallePedido);

        [OperationContract]
        Task<IEnumerable<DetallePedido>> GetAllDetallePedidoAsync();
    }
}
