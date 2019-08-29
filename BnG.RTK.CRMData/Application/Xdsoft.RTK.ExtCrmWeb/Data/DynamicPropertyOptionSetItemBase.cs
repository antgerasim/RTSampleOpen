namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DynamicPropertyOptionSetItemBase")]
    public partial class DynamicPropertyOptionSetItemBase
    {
        public Guid OrganizationId { get; set; }

        [Key]
        public Guid DynamicPropertyOptionSetValueId { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? DynamicPropertyOptionSetValueSequenceNumber { get; set; }

        public Guid? DynamicPropertyId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(100)]
        public string DynamicPropertyOptionName { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? DynamicPropertyOptionValue { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(100)]
        public string DynamicPropertyOptionDescription { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual DynamicPropertyBase DynamicPropertyBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
