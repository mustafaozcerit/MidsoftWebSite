using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class PermissionPolicyMemberPermissionsObject
    {
        public Guid Oid { get; set; }
        public string Members { get; set; }
        public int? ReadState { get; set; }
        public int? WriteState { get; set; }
        public string Criteria { get; set; }
        public Guid? TypePermissionObject { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual PermissionPolicyTypePermissionsObject TypePermissionObjectNavigation { get; set; }
    }
}
