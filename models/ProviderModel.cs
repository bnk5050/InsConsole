using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsConsole.models
{
    public class Provider
    {
        public long PrviderId { get; set; }
        public long LocationId { get; set; }
        public string? ProviderName { get; set; }

        public Provider(long PrviderId_, long LocationId_, string? ProviderName_)
        {
            this.PrviderId = PrviderId_;
            this.LocationId = LocationId_;
            this.ProviderName = ProviderName_;
        }
    }
}
