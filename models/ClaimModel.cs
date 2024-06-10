using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsConsole.models
{
    public class Claim
    {
        public string ClaimNum { get; set; }
        public long VisitId { get; set; }
        public long PlanId { get; set; }
        public long ProviderId { get; set; }
        public string ServiceDate { get; set; }
        public string Service { get; set; }
        public decimal ProviderCharge { get; set; }
        public decimal InsDiscount { get; set; }
        public decimal InsPayment { get; set; }
        public decimal CopayDue { get; set; }
        public decimal DeductDue { get; set; }
        public decimal CoinsDue { get; set; }
        public decimal NotCoveredDue { get; set; }

        public Claim(string ClaimNum_, long VisitId_, long PlanId_, long ProviderId_, string ServiceDate_, string Service_, decimal ProviderCharge_, decimal InsDiscount_, decimal InsPayment_, decimal CopayDue_, decimal DeductDue_, decimal CoinsDue_, decimal NotCoveredDue_)
        {
            this.ClaimNum = ClaimNum_;
            this.VisitId = VisitId_;
            this.PlanId = PlanId_;
            this.ProviderId = ProviderId_;
            this.ServiceDate = ServiceDate_;
            this.Service = Service_;
            this.ProviderCharge = ProviderCharge_;
            this.InsDiscount = InsDiscount_;
            this.InsPayment = InsPayment_;
            this.CopayDue = CopayDue_;
            this.DeductDue = DeductDue_;
            this.CoinsDue = CoinsDue_;
            this.NotCoveredDue = NotCoveredDue_;
        }
    }
}
