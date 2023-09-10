using Fintranet.MVP.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Fintranet.MVP.Core.Entities
{
    public class VehicleEntity : Entity
    {
        public VehicleTypeEnum Type { get; set; }

        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public LocationEntity Location { get; set; }
        public ICollection<PassedLogEntity> PassedTimes { get; set; }
    }
}
