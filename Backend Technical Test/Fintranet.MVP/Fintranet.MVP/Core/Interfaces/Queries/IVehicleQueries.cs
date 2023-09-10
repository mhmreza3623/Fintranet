using Fintranet.MVP.Core.Entities;

namespace Fintranet.MVP.Core.Interfaces.Queries
{
    internal interface IVehicleQueries
    {
        List<VehicleEntity> GetAll();
    }
}