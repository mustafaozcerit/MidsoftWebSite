using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class XpoInstanceKey
    {
        public int Oid { get; set; }
        public Guid? KeyId { get; set; }
        public Guid? InstanceId { get; set; }
        public string Properties { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
