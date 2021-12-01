using System;
using System.Collections.Generic;

#nullable disable

namespace Rocket_Elevators_REST_API.Models
{
    public partial class ArInternalMetadatum
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
