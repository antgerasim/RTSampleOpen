namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChannelAccessProfileRuleItemBase")]
    public partial class ChannelAccessProfileRuleItemBase
    {
        public Guid? AssociatedChannelAccessProfile { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SolutionId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? SequenceNumber { get; set; }

        public string Description { get; set; }

        public Guid ChannelAccessProfileRuleItemIdUnique { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool IsManaged { get; set; }

        public Guid ChannelAccessProfileRuleId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public string ConditionXml { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ChannelAccessProfileRuleItemId { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }
    }
}
