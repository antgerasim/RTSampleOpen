namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiscountBase")]
    public partial class DiscountBase
    {
        [Key]
        public Guid DiscountId { get; set; }

        public Guid DiscountTypeId { get; set; }

        public decimal? LowQuantity { get; set; }

        public decimal? HighQuantity { get; set; }

        public decimal? Percentage { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? StatusCode { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount_Base { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual DiscountTypeBase DiscountTypeBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
