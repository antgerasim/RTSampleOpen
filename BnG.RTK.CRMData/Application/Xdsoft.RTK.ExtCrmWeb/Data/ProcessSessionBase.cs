namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessSessionBase")]
    public partial class ProcessSessionBase
    {
        public Guid? ExecutedBy { get; set; }

        public int? ErrorCode { get; set; }

        public DateTime? ExecutedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public string Comments { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(256)]
        public string ActivityName { get; set; }

        [Key]
        public Guid ProcessSessionId { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public DateTime? StartedOn { get; set; }

        public DateTime? CompletedOn { get; set; }

        public int? StatusCode { get; set; }

        public Guid? NextLinkedSessionId { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        public Guid? OriginatingSessionId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? PreviousLinkedSessionId { get; set; }

        public Guid? StartedBy { get; set; }

        public string ProtectionKey { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public string ProcessState { get; set; }

        [StringLength(256)]
        public string StepName { get; set; }

        public string InputArguments { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(256)]
        public string ProcessStageName { get; set; }

        public int StateCode { get; set; }

        public Guid? ProcessId { get; set; }

        public DateTime? CanceledOn { get; set; }

        public Guid? CompletedBy { get; set; }

        public Guid? CanceledBy { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual WorkflowBaseIds WorkflowBaseIds { get; set; }
    }
}
