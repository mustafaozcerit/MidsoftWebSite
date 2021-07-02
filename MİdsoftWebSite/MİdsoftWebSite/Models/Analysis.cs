using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class Analysis
    {
        public Guid Oid { get; set; }
        public string DimensionPropertiesString { get; set; }
        public string Name { get; set; }
        public string Criteria { get; set; }
        public string ObjectTypeName { get; set; }
        public byte[] ChartSettingsContent { get; set; }
        public byte[] PivotGridSettingsContent { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
