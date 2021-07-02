using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class HomePage
    {
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string AnaSayfa { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
    }
}
