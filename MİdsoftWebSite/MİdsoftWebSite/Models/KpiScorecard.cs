using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class KpiScorecard
    {
        public KpiScorecard()
        {
            KpiScorecardScorecardsKpiInstanceIndicators = new HashSet<KpiScorecardScorecardsKpiInstanceIndicator>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<KpiScorecardScorecardsKpiInstanceIndicator> KpiScorecardScorecardsKpiInstanceIndicators { get; set; }
    }
}
