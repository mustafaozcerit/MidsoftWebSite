using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class Resource
    {
        public Resource()
        {
            ResourceResourcesEventEvents = new HashSet<ResourceResourcesEventEvent>();
        }

        public Guid Oid { get; set; }
        public string Caption { get; set; }
        public int? Color { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<ResourceResourcesEventEvent> ResourceResourcesEventEvents { get; set; }
    }
}
