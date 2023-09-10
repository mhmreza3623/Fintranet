using Fintranet.MVP.Core.Enums;
using System.Reflection.Metadata.Ecma335;

namespace Fintranet.MVP.Core.Entities
{
    public class LocationEntity : Entity
    {
        public ProvinceEnum Province { get; set; }
        public string Address { get; set; }
    }
}