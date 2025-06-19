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
    public class VehiculoRepositoryImpl : RepositoryImpl<Vehiculo>, IVehiculoRepository
    {
        public VehiculoRepositoryImpl(DulceFacilContext context) : base(context)
        {
        }
    }
}
