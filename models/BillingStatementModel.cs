using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsConsole.models
{
    public class BillingStatement
    {
        public long StatementId { get; set; }
        public long FKProviderProviderId { get; set; }
        public string DateIssued { get; set; }
        public string Account { get; set; }
        public decimal? Charges { get; set; }
        public decimal? Payments { get; set; }
        public decimal? BalanceDue { get; set; }
        public string? FKClaimClaimNum { get; set; }
        public long FKPersonPersonId { get; set; }

        public BillingStatement(long StatementId_, long FKProviderProviderId_, string DateIssued_, string Account_, decimal? Charges_, decimal? Payments_, decimal? BalanceDue_, string? FKClaimClaimNum_, long FKPersonPersonId_)
        {
            this.StatementId = StatementId_;
            this.FKProviderProviderId = FKProviderProviderId_;
            this.DateIssued = DateIssued_;
            this.Account = Account_;
            this.Charges = Charges_;
            this.Payments = Payments_;
            this.BalanceDue = BalanceDue_;
            this.FKClaimClaimNum = FKClaimClaimNum_;
            this.FKPersonPersonId = FKPersonPersonId_;
        }
    }
}
