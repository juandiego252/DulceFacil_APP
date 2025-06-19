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
    public class DetallePedidoServiceImpl : IDetallePedidoService
    {
        private readonly IDetallePedidoRepository _detallePedidoRepository;

        public DetallePedidoServiceImpl(DulceFacilContext context)
        {
            _detallePedidoRepository = new DetallePedidoRepositoryImpl(context);
        }

        public async Task AddDetallePedidoAsync(DetallePedido detallePedido)
        {
            await _detallePedidoRepository.AddAsync(detallePedido);
        }

        public async Task DeleteDetallePedidoAsync(int idDetallePedido)
        {
            await _detallePedidoRepository.DeleteAsync(idDetallePedido);
        }

        public async Task<IEnumerable<DetallePedido>> GetAllDetallePedidoAsync()
        {
            return await _detallePedidoRepository.GetAllAsync();
        }

        public async Task<DetallePedido> GetDetallePedidoByIdAsync(int idDetallePedido)
        {
            return await _detallePedidoRepository.GetByIdAsync(idDetallePedido);
        }

        public async Task UpdateDetallePedidoAsync(DetallePedido detallePedido)
        {
            await _detallePedidoRepository.UpdateAsync(detallePedido);
        }
    }
}
