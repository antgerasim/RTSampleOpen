namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeadToOpportunitySalesProcessBase")]
    public partial class LeadToOpportunitySalesProcessBase
    {
        public Guid? LeadId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ProcessId { get; set; }

        public Guid? ActiveStageId { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ActiveStageStartedOn { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [Key]
        public Guid BusinessProcessFlowInstanceId { get; set; }

        public Guid OrganizationId { get; set; }

        public int StateCode { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? StatusCode { get; set; }

        public Guid? OpportunityId { get; set; }

        public DateTime? CompletedOn { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Duration { get; set; }
    }
}
