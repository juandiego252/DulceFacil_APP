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
    public interface IProductoService
    {
        [OperationContract]
        Task AddProductoAsync(Producto producto);

        [OperationContract]
        Task UpdateProductoAsync(Producto producto);

        [OperationContract]
        Task DeleteProductoAsync(int idProducto);

        [OperationContract]
        Task<Producto> GetProductoByIdAsync(int idProducto);

        [OperationContract]
        Task<IEnumerable<Producto>> GetAllProductosAsync();

    }
}
