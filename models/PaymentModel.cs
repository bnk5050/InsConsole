using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsConsole.models
{
	public class Payment
	{
		public long PaymentId { get; set; }
		public string Date { get; set; }
		public string ReceiptNum { get; set; }
		public string PaymentType { get; set; }
		public decimal? Amount { get; set; }
		public long FKProviderProviderId { get; set; }

		public Payment(long PaymentId_, string Date_, string ReceiptNum_, string PaymentType_, decimal? Amount_, long FKProviderProviderId_)
		{
			this.PaymentId = PaymentId_;
			this.Date = Date_;
			this.ReceiptNum = ReceiptNum_;
			this.PaymentType = PaymentType_;
			this.Amount = Amount_;
			this.FKProviderProviderId = FKProviderProviderId_;
		}
	}
}
