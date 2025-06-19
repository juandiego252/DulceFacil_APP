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
    public class PedidoServiceImpl : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoServiceImpl(DulceFacilContext context)
        {
            _pedidoRepository = new PedidoRepositoryImpl(context);
        }
        public async Task AddPedidoAsync(Pedido pedido)
        {
            await _pedidoRepository.AddAsync(pedido);
        }

        public async Task DeletePedidoAsync(int idPedido)
        {
            await _pedidoRepository.DeleteAsync(idPedido);
        }

        public async Task<IEnumerable<Pedido>> GetAllPedidosAsync()
        {
            return await _pedidoRepository.GetAllAsync();
        }

        public async Task<Pedido> GetPedidoByIdAsync(int idPedido)
        {
            return await _pedidoRepository.GetByIdAsync(idPedido);
        }

        public async Task UpdatePedidoAsync(Pedido pedido)
        {
            await _pedidoRepository.UpdateAsync(pedido);
        }
    }
}
