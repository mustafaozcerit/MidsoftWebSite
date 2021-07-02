using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class KpiInstance
    {
        public KpiInstance()
        {
            KpiDefinitions = new HashSet<KpiDefinition>();
            KpiHistoryItems = new HashSet<KpiHistoryItem>();
            KpiScorecardScorecardsKpiInstanceIndicators = new HashSet<KpiScorecardScorecardsKpiInstanceIndicator>();
        }

        public Guid Oid { get; set; }
        public DateTime? ForceMeasurementDateTime { get; set; }
        public Guid? KpiDefinition { get; set; }
        public string Settings { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual KpiDefinition KpiDefinitionNavigation { get; set; }
        public virtual ICollection<KpiDefinition> KpiDefinitions { get; set; }
        public virtual ICollection<KpiHistoryItem> KpiHistoryItems { get; set; }
        public virtual ICollection<KpiScorecardScorecardsKpiInstanceIndicator> KpiScorecardScorecardsKpiInstanceIndicators { get; set; }
    }
}
