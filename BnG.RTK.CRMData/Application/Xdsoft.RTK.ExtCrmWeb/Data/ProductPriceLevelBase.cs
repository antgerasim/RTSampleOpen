namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductPriceLevelBase")]
    public partial class ProductPriceLevelBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductPriceLevelBase()
        {
            RecommendationCacheBase = new HashSet<RecommendationCacheBase>();
        }

        public Guid PriceLevelId { get; set; }

        [Key]
        public Guid ProductPriceLevelId { get; set; }

        public Guid? UoMId { get; set; }

        public Guid? UoMScheduleId { get; set; }

        public Guid? DiscountTypeId { get; set; }

        public Guid ProductId { get; set; }

        public decimal? Percentage { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? QuantitySellingCode { get; set; }

        public int? RoundingPolicyCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? PricingMethodCode { get; set; }

        public int? RoundingOptionCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? RoundingOptionAmount { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? RoundingOptionAmount_Base { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? StageId { get; set; }

        public Guid? ProcessId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public virtual DiscountTypeBase DiscountTypeBase { get; set; }

        public virtual PriceLevelBase PriceLevelBase { get; set; }

        public virtual ProductBase ProductBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecommendationCacheBase> RecommendationCacheBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }

        public virtual UoMScheduleBase UoMScheduleBase { get; set; }

        public virtual UoMBase UoMBase { get; set; }
    }
}
