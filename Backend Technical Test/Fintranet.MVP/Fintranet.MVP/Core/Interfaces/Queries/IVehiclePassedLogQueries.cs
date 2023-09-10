using Fintranet.MVP.Core.Entities;

namespace Fintranet.MVP.Core.Interfaces.Queries
{
    public interface IVehiclePassedLogQueries
    {
        List<PassedLogEntity> GetPassedLogs(int vehicleId);
    }
}