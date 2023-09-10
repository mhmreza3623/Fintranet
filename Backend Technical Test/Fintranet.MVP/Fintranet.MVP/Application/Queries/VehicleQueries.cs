using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fintranet.MVP.Core.Entities;
using Fintranet.MVP.Core.Interfaces.Queries;
using Fintranet.MVP.Core.Interfaces.Repositories;

namespace Fintranet.MVP.Application.Queries
{
    public class VehicleQueries: IVehicleQueries
    {
        private readonly IDbRepository<VehicleEntity> _vehicleRepos;

        public VehicleQueries(IDbRepository<VehicleEntity> vehicleRepos)
        {
            this._vehicleRepos = vehicleRepos;
        }

        public List<VehicleEntity> GetAll()
        {
            List<VehicleEntity> vehicleEntities = _vehicleRepos.GetAll().ToList();

            return vehicleEntities;
        }
    }
}
