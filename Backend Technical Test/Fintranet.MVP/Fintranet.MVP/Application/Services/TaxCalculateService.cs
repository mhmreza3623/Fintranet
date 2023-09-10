using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fintranet.MVP.Core.BusinessObjects;
using Fintranet.MVP.Core.Interfaces.ApplicationServices;
using Fintranet.MVP.Core.Interfaces.DomainServices;

namespace Fintranet.MVP.Application.Services
{
    internal class TaxCalculateAppService : ITaxCalculateAppService
    {
        private readonly ITaxCalculation _taxCalculation;

        public TaxCalculateAppService(ITaxCalculation taxCalculation)
        {
            _taxCalculation = taxCalculation;
        }
        public void CalculateTax(List<VehicleBusinessObject> vehicles)
        {
            foreach (VehicleBusinessObject vehicle in vehicles)
            {
                _taxCalculation.GetTax(vehicle);
            }
        }
    }
}
