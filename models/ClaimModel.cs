using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsConsole.models
{
    public class Claim
    {
        public string? ClaimNum { get; set; }
        public long VisitId { get; set; }
        public long PlanId { get; set; }
        public long ProviderId { get; set; }
        public string? ServiceDate { get; set; }
        public string? Service { get; set; }
        public decimal ProviderCharge { get; set; }
        public decimal InsDiscount { get; set; }
        public decimal InsPayment { get; set; }
        public decimal CopayDue { get; set; }
        public decimal DeductDue { get; set; }
        public decimal CoinsDue { get; set; }
        public decimal NotCoveredDue { get; set; }
    
    }
}
