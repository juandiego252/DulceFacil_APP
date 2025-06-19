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
    public interface IUsuarioService
    {
        [OperationContract]
        Task AddUsuarioAsync(Usuario usuario);

        [OperationContract]
        Task UpdateUsuarioAsync(Usuario usuario);

        [OperationContract]
        Task DeleteUsuarioAsync(int usuarioId);

        [OperationContract]
        Task<Usuario> GetUsuarioByIdAsync(int usuarioId);

        [OperationContract]
        Task<IEnumerable<Usuario>> GetAllUsuariosAsync();
    }
}
