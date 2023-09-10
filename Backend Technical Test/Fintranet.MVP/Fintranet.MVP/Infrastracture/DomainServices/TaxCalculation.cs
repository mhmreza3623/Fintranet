using Fintranet.MVP.Core.BusinessObjects;
using Fintranet.MVP.Core.Common;
using Fintranet.MVP.Core.Enums;
using Fintranet.MVP.Core.Interfaces.DomainServices;

namespace Fintranet.MVP.Infrastracture.DomainServices
{
    public class TaxCalculation : ITaxCalculation
    {
        public int GetTax(VehicleBusinessObject vehicle)
        {
            var passedTimes = vehicle.PassedTimes;

            DateTime intervalStart = passedTimes[0];
            int totalFee = 0;

            foreach (var passedTime in passedTimes)
            {
                int nextFee = GetTollFee(passedTime, vehicle);
                int tempFee = GetTollFee(intervalStart, vehicle);

                long diffInMillies = passedTime.Millisecond - intervalStart.Millisecond;
                long minutes = diffInMillies / 1000 / 60;

                if (minutes <= 60)
                {
                    if (totalFee > 0) totalFee -= tempFee;
                    if (nextFee >= tempFee) tempFee = nextFee;
                    totalFee += tempFee;
                }
                else
                {
                    totalFee += nextFee;
                }
            }
            if (totalFee > 60) totalFee = 60;
            return totalFee;
        }

        private int GetTollFee(DateTime date, VehicleBusinessObject vehicle)
        {
            if (date.IsTollFreeDate() || vehicle.IsTollFreeVehicle())
            {
                return 0;
            }

            return date.GetHourFee();
        }
    }
}
