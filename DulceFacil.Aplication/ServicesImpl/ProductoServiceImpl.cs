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
    public class ProductoServiceImpl : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoServiceImpl(DulceFacilContext context)
        {
            _productoRepository = new ProductoRepositoryImpl(context);
        }
        public async Task AddProductoAsync(Producto producto)
        {
            await _productoRepository.AddAsync(producto);
        }

        public async Task DeleteProductoAsync(int idProducto)
        {
            await _productoRepository.DeleteAsync(idProducto);
        }

        public async Task<IEnumerable<Producto>> GetAllProductosAsync()
        {
            return await _productoRepository.GetAllAsync();
        }

        public async Task<Producto> GetProductoByIdAsync(int idProducto)
        {
            return await _productoRepository.GetByIdAsync(idProducto);
        }

        public async Task UpdateProductoAsync(Producto producto)
        {
            await _productoRepository.UpdateAsync(producto);
        }
    }
}
