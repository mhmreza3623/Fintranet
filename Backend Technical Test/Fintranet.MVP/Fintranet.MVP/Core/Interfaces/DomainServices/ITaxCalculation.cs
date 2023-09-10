using Fintranet.MVP.Core.BusinessObjects;

namespace Fintranet.MVP.Core.Interfaces.DomainServices
{
    public interface ITaxCalculation
    {
        int GetTax(VehicleBusinessObject vehicle);
    }
}
