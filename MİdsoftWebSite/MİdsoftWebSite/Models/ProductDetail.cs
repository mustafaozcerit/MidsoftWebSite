using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class ProductDetail
    {
        public Guid Oid { get; set; }
        public string PersistentProperty { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? Products { get; set; }
        public Guid? Products1 { get; set; }
        public string ProductsName { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Icerik2 { get; set; }
        public string Icerik3 { get; set; }
        public byte[] Fotograf { get; set; }
        public byte[] Fotograf1 { get; set; }
        public byte[] Fotograf2 { get; set; }

        public virtual Product Products1Navigation { get; set; }
        public virtual Product ProductsNavigation { get; set; }
    }
}
