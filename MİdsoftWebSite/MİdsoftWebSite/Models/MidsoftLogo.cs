using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class MidsoftLogo
    {
        public Guid Oid { get; set; }
        public byte[] Fotograf { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
