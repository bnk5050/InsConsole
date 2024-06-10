using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsConsole.models
{
    public class InsPlan
    {
        public long PlanId { get; set; }
        public string? PlanName { get; set; }
        public decimal IndividualDeductIn { get; set; }
        public decimal FamilyDeductIn { get; set; }
        public decimal IndividualDeductOut { get; set; }
        public decimal FamilyDeductOut { get; set; }
        public decimal ReimbursementFunds { get; set; }
        public int? CoPay { get; set; }
        public int? CoinsuranceShareUrgentCare { get; set; }
        public int? CoinsuranceShareExams { get; set; }
        public int? CoinsuranceShareER { get; set; }
        public decimal? FamilyOutOfPocketMaxIn { get; set; }
        public decimal? FamilyOutofPocketMaxOut { get; set; }
        public decimal? IndividualOutOfPocketMaxIn { get; set; }
        public decimal? IndividualOutOfPocketMaxOut { get; set; }

    }
}
