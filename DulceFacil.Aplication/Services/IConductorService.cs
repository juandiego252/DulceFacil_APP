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
    public interface IConductorService
    {

        [OperationContract]
        Task AddConductorAsync(Conductor conductor);

        [OperationContract]
        Task UpdateConductorAsync(Conductor conductor);

        [OperationContract]
        Task DeleteConductorAsync(int idConductor);

        [OperationContract]
        Task<Conductor> GetConductorByIdAsync(int idConductor);

        [OperationContract]
        Task<IEnumerable<Conductor>> GetAllConductoresAsync();
    }
}
