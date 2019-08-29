namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AsyncOperationBase")]
    public partial class AsyncOperationBase
    {
        [StringLength(160)]
        public string MessageName { get; set; }

        public int Depth { get; set; }

        public int? PrimaryEntityType { get; set; }

        public string Data { get; set; }

        public Guid? RegardingObjectId { get; set; }

        [StringLength(256)]
        public string WorkflowStageName { get; set; }

        public int? OperationType { get; set; }

        [StringLength(256)]
        public string DependencyToken { get; set; }

        [StringLength(256)]
        public string RecurrencePattern { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        public DateTime? PostponeUntil { get; set; }

        public string WorkflowState { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid OwningBusinessUnit { get; set; }

        public bool? IsWaitingForEvent { get; set; }

        public Guid CreatedBy { get; set; }

        public int? ErrorCode { get; set; }

        public Guid ModifiedBy { get; set; }

        public Guid CorrelationId { get; set; }

        public DateTime? RecurrenceStartTime { get; set; }

        public int? StatusCode { get; set; }

        [Key]
        public Guid AsyncOperationId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Sequence { get; set; }

        public Guid? RequestId { get; set; }

        public bool? WorkflowIsBlocked { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string Message { get; set; }

        public DateTime? StartedOn { get; set; }

        [StringLength(256)]
        public string HostId { get; set; }

        public int StateCode { get; set; }

        public Guid? WorkflowActivationId { get; set; }

        public DateTime? CompletedOn { get; set; }

        public DateTime CorrelationUpdatedTime { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? RetryCount { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        public string FriendlyMessage { get; set; }

        public double ExecutionTimeSpan { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? OwningExtensionId { get; set; }

        public Guid OwnerId { get; set; }

        [StringLength(4000)]
        public string OwningExtensionIdName { get; set; }

        public int? OwningExtensionTypeCode { get; set; }

        public int OwnerIdType { get; set; }

        public int? Subtype { get; set; }

        public Guid? ParentPluginExecutionId { get; set; }
    }
}
