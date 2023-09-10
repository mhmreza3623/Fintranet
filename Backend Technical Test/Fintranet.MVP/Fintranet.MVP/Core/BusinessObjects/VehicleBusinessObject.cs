using Fintranet.MVP.Core.Dtos;
using Fintranet.MVP.Core.Entities;
using Fintranet.MVP.Core.Enums;

namespace Fintranet.MVP.Core.BusinessObjects
{
    public class VehicleBusinessObject
    {
        public LocationDto Location { get; private set; }
        public VehicleTypeEnum Type { get; private set; }
        public DateTime[] PassedTimes { get; private set; }


        public VehicleBusinessObject(VehicleTypeEnum vehicleType, DateTime[] passedTimes, LocationDto location)
        {
            PassedTimes = passedTimes;
            Type = vehicleType;
            this.Location = location;
        }

        public bool IsFreeToll()
        {
            return IsFreeToll();
        }
    }
}
