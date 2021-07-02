using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class AboutU
    {
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int? Index { get; set; }
        public string Icerik2 { get; set; }
        public string Icerik3 { get; set; }
    }
}
