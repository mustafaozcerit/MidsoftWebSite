using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class KpiHistoryItem
    {
        public Guid Oid { get; set; }
        public Guid? KpiInstance { get; set; }
        public DateTime? RangeStart { get; set; }
        public DateTime? RangeEnd { get; set; }
        public double? Value { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual KpiInstance KpiInstanceNavigation { get; set; }
    }
}
