using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class Contact
    {
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Konum { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
