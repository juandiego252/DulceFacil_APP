using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacil.Domain.Models.Abstractions;
using DulceFacil.Domain.Models.Entities;
using DulceFacil.Infraestructure.DataAccess.DataEFCore;

namespace DulceFacil.Infraestructure.DataAccess.Repository
{
    public class PedidoRepositoryImpl : RepositoryImpl<Pedido>, IPedidoRepository
    {
        public PedidoRepositoryImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
