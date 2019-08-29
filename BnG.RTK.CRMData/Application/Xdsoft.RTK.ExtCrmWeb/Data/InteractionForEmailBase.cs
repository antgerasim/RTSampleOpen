namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InteractionForEmailBase")]
    public partial class InteractionForEmailBase
    {
        [StringLength(1250)]
        public string InteractionUserAgent { get; set; }

        [StringLength(1250)]
        public string InteractedComponentText { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? EmailActivityId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int statecode { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? statuscode { get; set; }

        public int InteractionType { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        [StringLength(1250)]
        public string InteractionReplyId { get; set; }

        [StringLength(1250)]
        public string InteractionRepliedBy { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [Key]
        public Guid InteractionForEmailId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? EmailInteractionReplyId { get; set; }

        public DateTime? EmailInteractionTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [StringLength(1250)]
        public string InteractionLocation { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid OwnerId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
