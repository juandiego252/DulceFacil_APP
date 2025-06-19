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
    public interface ICategoriaClienteService
    {
        [OperationContract]
        Task AddCategoriaClienteAsync(CategoriaCliente categoriaCliente);

        [OperationContract]
        Task UpdateCategoriaClienteAsync(CategoriaCliente categoriaCliente);

        [OperationContract]
        Task DeleteCategoriaClienteAsync(int idCategoria);

        [OperationContract]
        Task<CategoriaCliente> GetCategoriaClienteByIdAsync(int idCategoria);

        [OperationContract]
        Task<IEnumerable<CategoriaCliente>> GetAllCategoriasClientesAsync();
    }
}
