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
    internal class CategoriaClienteServiceImpl : ICategoriaClienteService
    {
        private readonly ICategoriaClienteRepository _categoriaClienteRepository;

        public CategoriaClienteServiceImpl(DulceFacilContext context)
        {
            _categoriaClienteRepository = new CategoriaClienteRepositoryImpl(context);
        }
        public async Task AddCategoriaClienteAsync(CategoriaCliente categoriaCliente)
        {
            await _categoriaClienteRepository.AddAsync(categoriaCliente);
        }

        public async Task DeleteCategoriaClienteAsync(int idCategoria)
        {
            await _categoriaClienteRepository.DeleteAsync(idCategoria);
        }

        public async Task<IEnumerable<CategoriaCliente>> GetAllCategoriasClientesAsync()
        {
            return await _categoriaClienteRepository.GetAllAsync();
        }

        public async Task<CategoriaCliente> GetCategoriaClienteByIdAsync(int idCategoria)
        {
            return await _categoriaClienteRepository.GetByIdAsync(idCategoria);
        }

        public async Task UpdateCategoriaClienteAsync(CategoriaCliente categoriaCliente)
        {
            await _categoriaClienteRepository.UpdateAsync(categoriaCliente);
        }
    }
}
