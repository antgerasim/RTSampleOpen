namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DelveActionHubBase")]
    public partial class DelveActionHubBase
    {
        [StringLength(250)]
        public string MailWebLink { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [StringLength(250)]
        public string SenderImageUrl { get; set; }

        [StringLength(320)]
        public string MessageId { get; set; }

        public string Description { get; set; }

        [StringLength(200)]
        public string Subject { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedTime { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StateCode { get; set; }

        public Guid? OrganizationId { get; set; }

        public DateTime? CreatedTime { get; set; }

        public int? StatusCode { get; set; }

        public int? SenderEntityObjectTypeCode { get; set; }

        public DateTime? MessageTime { get; set; }

        public Guid? RecordId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CardType { get; set; }

        public Guid? RegardingObjectId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid DelveActionHubId { get; set; }

        [StringLength(160)]
        public string IconClassName { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(250)]
        public string Sender { get; set; }

        public string RelatedMailIds { get; set; }

        public Guid? SenderEntityId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        public int? RecordIdObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        [StringLength(4000)]
        public string RecordIdName { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
