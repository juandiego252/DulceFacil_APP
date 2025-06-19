using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacil.Aplication.Services;
using DulceFacil.Domain.Models.Abstractions;
using DulceFacil.Domain.Models.Entities;
using DulceFacil.Infraestructure.DataAccess.DataEFCore;
using DulceFacil.Infraestructure.DataAccess.Repository;

namespace DulceFacil.Aplication.ServicesImpl
{
    public class UsuarioServiceImpl : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioServiceImpl(DulceFacilContext context)
        {
            _usuarioRepository = new UsuarioRepositoryImpl(context);
        }
        public async Task AddUsuarioAsync(Usuario usuario)
        {
            await _usuarioRepository.AddAsync(usuario);
        }

        public async Task DeleteUsuarioAsync(int usuarioId)
        {
            await _usuarioRepository.DeleteAsync(usuarioId);
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuariosAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }

        public async Task<Usuario> GetUsuarioByIdAsync(int usuarioId)
        {
            return await _usuarioRepository.GetByIdAsync(usuarioId);
        }

        public async Task UpdateUsuarioAsync(Usuario usuario)
        {
            await _usuarioRepository.UpdateAsync(usuario);
        }
    }
}
