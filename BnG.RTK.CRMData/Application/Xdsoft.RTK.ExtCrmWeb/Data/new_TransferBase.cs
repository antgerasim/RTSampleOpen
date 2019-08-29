namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_TransferBase
    {
        [Key]
        public Guid new_TransferId { get; set; }

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

        [StringLength(100)]
        public string new_name { get; set; }

        public string new_FetchQuery { get; set; }

        [StringLength(1000)]
        public string new_msg_text { get; set; }

        public Guid? new_From_StepId { get; set; }

        public Guid? new_To_StepId { get; set; }

        public Guid? new_WorkflowId { get; set; }

        public Guid? new_From_StageId { get; set; }

        public Guid? new_To_StageId { get; set; }

        public Guid? new_RouteId { get; set; }

        [StringLength(100)]
        public string new_number { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual new_RouteBase new_RouteBase { get; set; }

        public virtual new_StageBase new_StageBase { get; set; }

        public virtual new_StageBase new_StageBase1 { get; set; }

        public virtual new_StepBase new_StepBase { get; set; }

        public virtual new_StepBase new_StepBase1 { get; set; }

        public virtual WorkflowBaseIds WorkflowBaseIds { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
