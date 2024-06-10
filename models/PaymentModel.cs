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
		public string? Date { get; set; }
		public string? ReceiptNum { get; set; }
		public string? PaymentType { get; set; }
		public decimal? Amount { get; set; }
		public long FKProviderProviderId { get; set; }

	}
}
