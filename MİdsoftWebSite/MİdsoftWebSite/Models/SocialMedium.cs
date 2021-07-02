using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class SocialMedium
    {
        public Guid Oid { get; set; }
        public string Isim { get; set; }
        public byte[] Fotograf { get; set; }
        public string Link { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
