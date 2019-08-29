namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkflowLogBase")]
    public partial class WorkflowLogBase
    {
        public Guid AsyncOperationId { get; set; }

        public Guid ModifiedBy { get; set; }

        public DateTime? CompletedOn { get; set; }

        [Key]
        public Guid WorkflowLogId { get; set; }

        public string Description { get; set; }

        public string Message { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(256)]
        public string StageName { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(160)]
        public string StepName { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public int Status { get; set; }

        public int? ErrorCode { get; set; }

        [StringLength(160)]
        public string ActivityName { get; set; }

        [StringLength(256)]
        public string RegardingObjectIdName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(160)]
        public string RegardingObjectIdYomiName { get; set; }

        public string InteractionActivityResult { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? ChildWorkflowInstanceId { get; set; }

        public int? ChildWorkflowInstanceObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string AsyncOperationIdName { get; set; }

        [StringLength(4000)]
        public string ChildWorkflowInstanceIdName { get; set; }

        public int ObjectTypeCode { get; set; }

        public DateTime? StartedOn { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Duration { get; set; }
    }
}
