using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class XpobjectType
    {
        public XpobjectType()
        {
            PermissionPolicyRoles = new HashSet<PermissionPolicyRole>();
            XpweakReferenceObjectTypeNavigations = new HashSet<XpweakReference>();
            XpweakReferenceTargetTypeNavigations = new HashSet<XpweakReference>();
        }

        public int Oid { get; set; }
        public string TypeName { get; set; }
        public string AssemblyName { get; set; }

        public virtual ICollection<PermissionPolicyRole> PermissionPolicyRoles { get; set; }
        public virtual ICollection<XpweakReference> XpweakReferenceObjectTypeNavigations { get; set; }
        public virtual ICollection<XpweakReference> XpweakReferenceTargetTypeNavigations { get; set; }
    }
}
