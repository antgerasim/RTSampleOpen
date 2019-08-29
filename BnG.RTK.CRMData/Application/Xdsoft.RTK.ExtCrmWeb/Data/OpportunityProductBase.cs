namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpportunityProductBase")]
    public partial class OpportunityProductBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OpportunityProductBase()
        {
            OpportunityProductBase1 = new HashSet<OpportunityProductBase>();
        }

        public Guid? ProductId { get; set; }

        [Key]
        public Guid OpportunityProductId { get; set; }

        public int? PricingErrorCode { get; set; }

        public bool? IsProductOverridden { get; set; }

        public bool? IsPriceOverridden { get; set; }

        [Column(TypeName = "money")]
        public decimal? PricePerUnit { get; set; }

        public Guid OpportunityId { get; set; }

        [Column(TypeName = "money")]
        public decimal? BaseAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendedAmount { get; set; }

        public Guid? UoMId { get; set; }

        [Column(TypeName = "money")]
        public decimal? ManualDiscountAmount { get; set; }

        public decimal? Quantity { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "money")]
        public decimal? VolumeDiscountAmount { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tax { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(500)]
        public string ProductDescription { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [Column(TypeName = "money")]
        public decimal? BaseAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? ManualDiscountAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? VolumeDiscountAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? PricePerUnit_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tax_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendedAmount_Base { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? LineItemNumber { get; set; }

        public Guid? EntityImageId { get; set; }

        public int? SequenceNumber { get; set; }

        public int ProductTypeCode { get; set; }

        public Guid? ParentBundleId { get; set; }

        public int PropertyConfigurationStatus { get; set; }

        public Guid? ProductAssociationId { get; set; }

        public virtual OpportunityBase OpportunityBase { get; set; }

        public virtual ProductBase ProductBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityProductBase> OpportunityProductBase1 { get; set; }

        public virtual OpportunityProductBase OpportunityProductBase2 { get; set; }

        public virtual ProductAssociationBase ProductAssociationBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }

        public virtual UoMBase UoMBase { get; set; }
    }
}
