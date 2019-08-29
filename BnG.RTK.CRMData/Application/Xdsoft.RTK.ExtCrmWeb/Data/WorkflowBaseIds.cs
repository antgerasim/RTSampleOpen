namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkflowBaseIds
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkflowBaseIds()
        {
            bng_SchedulerSessionBase = new HashSet<bng_SchedulerSessionBase>();
            bng_ShedulerTaskBase = new HashSet<bng_ShedulerTaskBase>();
            new_RouteBase = new HashSet<new_RouteBase>();
            new_TransferBase = new HashSet<new_TransferBase>();
            ProcessSessionBase = new HashSet<ProcessSessionBase>();
            WorkflowDependencyBase = new HashSet<WorkflowDependencyBase>();
        }

        [Key]
        public Guid WorkflowId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bng_SchedulerSessionBase> bng_SchedulerSessionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bng_ShedulerTaskBase> bng_ShedulerTaskBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_RouteBase> new_RouteBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<new_TransferBase> new_TransferBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessSessionBase> ProcessSessionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkflowDependencyBase> WorkflowDependencyBase { get; set; }
    }
}
