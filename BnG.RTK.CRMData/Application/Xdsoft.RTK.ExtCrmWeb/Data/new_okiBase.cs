namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_okiBase
    {
        [Key]
        public Guid BusinessProcessFlowInstanceId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? OrganizationId { get; set; }

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
        public string bpf_name { get; set; }

        public Guid? ActiveStageId { get; set; }

        public Guid? ProcessId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public DateTime? CompletedOn { get; set; }

        public DateTime? ActiveStageStartedOn { get; set; }

        public Guid? bpf_new_project_initiativeid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? bpf_Duration { get; set; }
    }
}
