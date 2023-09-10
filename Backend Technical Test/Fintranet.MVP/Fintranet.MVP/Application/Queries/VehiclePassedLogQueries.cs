using Fintranet.MVP.Core.Entities;
using Fintranet.MVP.Core.Interfaces.Queries;
using Fintranet.MVP.Core.Interfaces.Repositories;

namespace Fintranet.MVP.Application.Queries
{
    public class VehiclePassedLogQueries : IVehiclePassedLogQueries
    {
        private readonly IDbRepository<PassedLogEntity> _passedRepos;

        public VehiclePassedLogQueries(IDbRepository<PassedLogEntity> passedRepos)
        {
            this._passedRepos = passedRepos;
        }

        public List<PassedLogEntity> GetPassedLogs(int vehicleId)
        {
            return _passedRepos.Get(q => q.VehicleId == vehicleId).ToList();
        }
    }
}
