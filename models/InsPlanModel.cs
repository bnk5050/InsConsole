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

        public InsPlan(long PlanId_, decimal IndividualDeductIn_, decimal FamilyDeductIn_, decimal IndividualDeductOut_, decimal FamilyDeductOut_, decimal ReimbursementFunds_, int? CoPay_, int? CoinsuranceShareUrgentCare_, int? CoinsuranceShareExams_, int? CoinsuranceShareER_, decimal? FamilyOutOfPocketMaxIn_, decimal? FamilyOutofPocketMaxOut_, decimal? IndividualOutOfPocketMaxIn_, decimal? IndividualOutOfPocketMaxOut_)
        {
            this.PlanId = PlanId_;
            this.IndividualDeductIn = IndividualDeductIn_;
            this.FamilyDeductIn = FamilyDeductIn_;
            this.IndividualDeductOut = IndividualDeductOut_;
            this.FamilyDeductOut = FamilyDeductOut_;
            this.ReimbursementFunds = ReimbursementFunds_;
            this.CoPay = CoPay_;
            this.CoinsuranceShareUrgentCare = CoinsuranceShareUrgentCare_;
            this.CoinsuranceShareExams = CoinsuranceShareExams_;
            this.CoinsuranceShareER = CoinsuranceShareER_;
            this.FamilyOutOfPocketMaxIn = FamilyOutOfPocketMaxIn_;
            this.FamilyOutofPocketMaxOut = FamilyOutofPocketMaxOut_;
            this.IndividualOutOfPocketMaxIn = IndividualOutOfPocketMaxIn_;
            this.IndividualOutOfPocketMaxOut = IndividualOutOfPocketMaxOut_;
        }
    }
}
