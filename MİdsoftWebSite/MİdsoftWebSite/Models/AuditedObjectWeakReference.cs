using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class AuditedObjectWeakReference
    {
        public AuditedObjectWeakReference()
        {
            AuditDataItemPersistents = new HashSet<AuditDataItemPersistent>();
        }

        public Guid Oid { get; set; }
        public Guid? GuidId { get; set; }
        public int? IntId { get; set; }
        public string DisplayName { get; set; }

        public virtual XpweakReference OidNavigation { get; set; }
        public virtual ICollection<AuditDataItemPersistent> AuditDataItemPersistents { get; set; }
    }
}
