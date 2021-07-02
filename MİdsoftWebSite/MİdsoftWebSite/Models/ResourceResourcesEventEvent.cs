using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class ResourceResourcesEventEvent
    {
        public Guid? Events { get; set; }
        public Guid? Resources { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual Event EventsNavigation { get; set; }
        public virtual Resource ResourcesNavigation { get; set; }
    }
}
