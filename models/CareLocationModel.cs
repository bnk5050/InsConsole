using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsConsole.models
{
    public class CareLocation
    {
        public long LocationId { get; set; }
        public string? Address { get; set; }

        public CareLocation(long LocationId_, string? Address_)
        {
            this.LocationId = LocationId_;
            this.Address = Address_;
        }
    }
}
