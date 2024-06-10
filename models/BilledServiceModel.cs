using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsConsole.models
{
    public class BilledService
    {
        public long ServiceId { get; set; }
        public string FKBillingStatementAccount { get; set; }
        public string SvcDate { get; set; }
        public long FKProviderProviderId { get; set; }
        public long FKLocationLocationId { get; set; }
        public string? ProvClaimNum { get; set; }
        public string? Services { get; set; }
        public decimal? Charges { get; set; }
        public decimal? InsPayment { get; set; }
        public decimal? PatientPayment { get; set; }
        public string? FKClaimClaimNum { get; set; }

        public BilledService(long ServiceId_, string FKBillingStatementAccount_, string SvcDate_, long FKProviderProviderId_, long FKLocationLocationId_, string? ProvClaimNum_, string? Services_, decimal? Charges_, decimal? InsPayment_, decimal? PatientPayment_, string? FKClaimClaimNum_)
        {
            this.ServiceId = ServiceId_;
            this.FKBillingStatementAccount = FKBillingStatementAccount_;
            this.SvcDate = SvcDate_;
            this.FKProviderProviderId = FKProviderProviderId_;
            this.FKLocationLocationId = FKLocationLocationId_;
            this.ProvClaimNum = ProvClaimNum_;
            this.Services = Services_;
            this.Charges = Charges_;
            this.InsPayment = InsPayment_;
            this.PatientPayment = PatientPayment_;
            this.FKClaimClaimNum = FKClaimClaimNum_;
        }
    }
}
