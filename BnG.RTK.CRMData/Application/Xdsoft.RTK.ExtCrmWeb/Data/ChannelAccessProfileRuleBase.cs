namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChannelAccessProfileRuleBase")]
    public partial class ChannelAccessProfileRuleBase
    {
        public bool IsManaged { get; set; }

        public Guid ChannelAccessProfileRuleIdUnique { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime OverwriteTime { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? WorkflowId { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int StateCode { get; set; }

        public int? StatusCode { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ChannelAccessProfileRuleId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int OwnerIdType { get; set; }
    }
}
