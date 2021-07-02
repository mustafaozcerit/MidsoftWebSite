using System;
using System.Collections.Generic;

#nullable disable

namespace MİdsoftWebSite.Models
{
    public partial class XpoState
    {
        public XpoState()
        {
            XpoStateAppearances = new HashSet<XpoStateAppearance>();
            XpoStateMachines = new HashSet<XpoStateMachine>();
            XpoTransitionSourceStateNavigations = new HashSet<XpoTransition>();
            XpoTransitionTargetStateNavigations = new HashSet<XpoTransition>();
        }

        public Guid Oid { get; set; }
        public string Caption { get; set; }
        public Guid? StateMachine { get; set; }
        public string MarkerValue { get; set; }
        public string TargetObjectCriteria { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual XpoStateMachine StateMachineNavigation { get; set; }
        public virtual ICollection<XpoStateAppearance> XpoStateAppearances { get; set; }
        public virtual ICollection<XpoStateMachine> XpoStateMachines { get; set; }
        public virtual ICollection<XpoTransition> XpoTransitionSourceStateNavigations { get; set; }
        public virtual ICollection<XpoTransition> XpoTransitionTargetStateNavigations { get; set; }
    }
}
