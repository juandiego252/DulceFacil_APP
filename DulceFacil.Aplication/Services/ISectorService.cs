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
    public interface ISectorService
    {
        [OperationContract]
        Task AddSectorAsync(Sector sector);

        [OperationContract]
        Task UpdateSectorAsync(Sector sector);

        [OperationContract]
        Task DeleteSectorAsync(int sectorId);

        [OperationContract]
        Task<Sector> GetSectorByIdAsync(int sectorId);

        [OperationContract]
        Task<IEnumerable<Sector>> GetAllSectorsAsync();
    }
}
