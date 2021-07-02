using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductDetailProducts1Navigations = new HashSet<ProductDetail>();
            ProductDetailProductsNavigations = new HashSet<ProductDetail>();
        }

        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string Isim { get; set; }
        public byte[] Fotograf { get; set; }

        public virtual ICollection<ProductDetail> ProductDetailProducts1Navigations { get; set; }
        public virtual ICollection<ProductDetail> ProductDetailProductsNavigations { get; set; }
    }
}
