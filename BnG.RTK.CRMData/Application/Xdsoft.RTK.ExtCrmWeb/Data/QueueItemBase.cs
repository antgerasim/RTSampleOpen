namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QueueItemBase")]
    public partial class QueueItemBase
    {
        [Key]
        public Guid QueueItemId { get; set; }

        public Guid? QueueId { get; set; }

        public Guid? ObjectId { get; set; }

        public int? ObjectTypeCode { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        public DateTime? EnteredOn { get; set; }

        public int? Priority { get; set; }

        public int? State { get; set; }

        public int? Status { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(500)]
        public string ToRecipients { get; set; }

        [StringLength(250)]
        public string Sender { get; set; }

        public Guid OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int StateCode { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int StatusCode { get; set; }

        public Guid? WorkerId { get; set; }

        public DateTime? WorkerIdModifiedOn { get; set; }

        [StringLength(4000)]
        public string WorkerIdName { get; set; }

        public int? WorkerIdType { get; set; }

        [StringLength(4000)]
        public string WorkerIdYomiName { get; set; }

        public virtual QueueBase QueueBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
