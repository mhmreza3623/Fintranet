using Fintranet.MVP.Core.BusinessObjects;
using Fintranet.MVP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintranet.MVP.Core.Common
{
    internal static class VehicleHelper
    {
        public static bool IsTollFreeVehicle(this VehicleBusinessObject vehicle)
        {
            if (vehicle == null) return false;

            switch (vehicle.Type)
            {
                case Enums.VehicleTypeEnum.Motorcycle:
                case Enums.VehicleTypeEnum.Tractor:
                case Enums.VehicleTypeEnum.Emergency:
                case Enums.VehicleTypeEnum.Diplomat:
                case Enums.VehicleTypeEnum.Foreign:
                case Enums.VehicleTypeEnum.Military:
                    return true;
                case Enums.VehicleTypeEnum.Car:
                case Enums.VehicleTypeEnum.Motorbike:
                    return false;
                default:
                    throw new Exception("not defind Vehicle Type.");
            }

        }
    }
}
