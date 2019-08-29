namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeedbackBase")]
    public partial class FeedbackBase
    {
        public DateTime? ClosedOn { get; set; }

        public int? MinRating { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public decimal? NormalizedRating { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? MaxRating { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int StateCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedByContact { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ClosedBy { get; set; }

        public Guid OwnerId { get; set; }

        public int? Source { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? Rating { get; set; }

        public int? StatusCode { get; set; }

        public Guid? RegardingObjectId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public string Comments { get; set; }

        [StringLength(4000)]
        public string Title { get; set; }

        [Key]
        public Guid FeedbackId { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? CreatedOnBehalfByContact { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        public virtual ContactBase ContactBase { get; set; }

        public virtual ContactBase ContactBase1 { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
