using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class XpweakReference
    {
        public XpweakReference()
        {
            AuditDataItemPersistentNewObjectNavigations = new HashSet<AuditDataItemPersistent>();
            AuditDataItemPersistentOldObjectNavigations = new HashSet<AuditDataItemPersistent>();
        }

        public Guid Oid { get; set; }
        public int? TargetType { get; set; }
        public string TargetKey { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }

        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual XpobjectType TargetTypeNavigation { get; set; }
        public virtual AuditedObjectWeakReference AuditedObjectWeakReference { get; set; }
        public virtual ICollection<AuditDataItemPersistent> AuditDataItemPersistentNewObjectNavigations { get; set; }
        public virtual ICollection<AuditDataItemPersistent> AuditDataItemPersistentOldObjectNavigations { get; set; }
    }
}
