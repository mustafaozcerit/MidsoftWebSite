using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class Referance
    {
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Isim { get; set; }
        public byte[] Fotograf { get; set; }
        public string Index { get; set; }
    }
}
