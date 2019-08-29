namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bng_SchedulerSessionBase
    {
        [Key]
        public Guid bng_SchedulerSessionId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int OwnerIdType { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int statecode { get; set; }

        public int? statuscode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(450)]
        public string bng_name { get; set; }

        public string bng_ErrorText { get; set; }

        public string bng_Query { get; set; }

        public int? bng_QueryType { get; set; }

        public int? bng_RecordsQuantity { get; set; }

        public Guid? bng_ShedulerTaskId { get; set; }

        public int? bng_StartType { get; set; }

        public Guid? bng_WorkflowId { get; set; }

        public virtual bng_ShedulerTaskBase bng_ShedulerTaskBase { get; set; }

        public virtual WorkflowBaseIds WorkflowBaseIds { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
