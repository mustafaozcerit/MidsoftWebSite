using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class PermissionPolicyRole
    {
        public PermissionPolicyRole()
        {
            PermissionPolicyNavigationPermissionsObjects = new HashSet<PermissionPolicyNavigationPermissionsObject>();
            PermissionPolicyTypePermissionsObjects = new HashSet<PermissionPolicyTypePermissionsObject>();
            PermissionPolicyUserUsersPermissionPolicyRoleRoles = new HashSet<PermissionPolicyUserUsersPermissionPolicyRoleRole>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public bool? IsAdministrative { get; set; }
        public bool? CanEditModel { get; set; }
        public int? PermissionPolicy { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }

        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual ICollection<PermissionPolicyNavigationPermissionsObject> PermissionPolicyNavigationPermissionsObjects { get; set; }
        public virtual ICollection<PermissionPolicyTypePermissionsObject> PermissionPolicyTypePermissionsObjects { get; set; }
        public virtual ICollection<PermissionPolicyUserUsersPermissionPolicyRoleRole> PermissionPolicyUserUsersPermissionPolicyRoleRoles { get; set; }
    }
}
