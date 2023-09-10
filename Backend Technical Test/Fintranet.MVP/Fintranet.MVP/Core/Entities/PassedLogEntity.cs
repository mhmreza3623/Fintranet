using System.ComponentModel.DataAnnotations.Schema;

namespace Fintranet.MVP.Core.Entities
{
    public class PassedLogEntity : Entity
    {
        public DateTime PassedTime { get; set; }

        [ForeignKey("VehicleId ")]
        public int VehicleId { get; set; }
        public VehicleEntity Vehicle { get; set; }
    }
}
