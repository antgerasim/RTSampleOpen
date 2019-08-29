namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoutingRuleItemBase")]
    public partial class RoutingRuleItemBase
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public string ConditionXml { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RoutingRuleItemId { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? AssignObjectIdModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? SequenceNumber { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool IsManaged { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public Guid? RoutedQueueId { get; set; }

        public Guid? AssignObjectId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid RoutingRuleId { get; set; }

        public Guid RoutingRuleItemIdUnique { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? AssignObjectIdType { get; set; }

        [StringLength(4000)]
        public string AssignObjectIdName { get; set; }

        [StringLength(4000)]
        public string AssignObjectIdYomiName { get; set; }
    }
}
