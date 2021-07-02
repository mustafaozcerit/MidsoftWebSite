using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class PermissionPolicyUser
    {
        public PermissionPolicyUser()
        {
            PermissionPolicyUserUsersPermissionPolicyRoleRoles = new HashSet<PermissionPolicyUserUsersPermissionPolicyRoleRole>();
        }

        public Guid Oid { get; set; }
        public string StoredPassword { get; set; }
        public bool? ChangePasswordOnFirstLogon { get; set; }
        public string UserName { get; set; }
        public bool? IsActive { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<PermissionPolicyUserUsersPermissionPolicyRoleRole> PermissionPolicyUserUsersPermissionPolicyRoleRoles { get; set; }
    }
}
