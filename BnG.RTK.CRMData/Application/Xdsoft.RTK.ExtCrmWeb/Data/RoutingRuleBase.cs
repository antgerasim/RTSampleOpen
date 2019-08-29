namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoutingRuleBase")]
    public partial class RoutingRuleBase
    {
        [StringLength(100)]
        public string Name { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SolutionId { get; set; }

        public Guid RoutingRuleIdUnique { get; set; }

        public Guid OrganizationId { get; set; }

        public bool IsManaged { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int StateCode { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid OwnerId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RoutingRuleId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        public string Description { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? WorkflowId { get; set; }

        public int? StatusCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public int OwnerIdType { get; set; }
    }
}
