namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChannelAccessProfileBase")]
    public partial class ChannelAccessProfileBase
    {
        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ChannelAccessProfileId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public bool? ViewKnowledgeArticles { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? SubmitFeedback { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public bool? WebAccess { get; set; }

        public bool? IsGuestProfile { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? HavePrivilegesChanged { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int StateCode { get; set; }

        public bool? FacebookAccess { get; set; }

        public bool? TwitterAccess { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OwnerId { get; set; }

        public Guid ChannelAccessProfileIdUnique { get; set; }

        public bool? EmailAccess { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public bool? RateKnowledgeArticles { get; set; }

        public bool? ViewArticleRating { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public bool? PhoneAccess { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? StatusCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int OwnerIdType { get; set; }
    }
}
