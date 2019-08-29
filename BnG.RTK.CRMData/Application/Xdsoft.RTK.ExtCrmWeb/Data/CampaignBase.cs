namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CampaignBase")]
    public partial class CampaignBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CampaignBase()
        {
            LeadBase = new HashSet<LeadBase>();
            OpportunityBase = new HashSet<OpportunityBase>();
            SalesOrderBase = new HashSet<SalesOrderBase>();
            QuoteBase = new HashSet<QuoteBase>();
            CampaignItemBase = new HashSet<CampaignItemBase>();
        }

        public int? TypeCode { get; set; }

        public DateTime? ProposedEnd { get; set; }

        [Column(TypeName = "money")]
        public decimal? BudgetedCost { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(128)]
        public string PromotionCodeName { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? PriceListId { get; set; }

        public int? StatusCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool? IsTemplate { get; set; }

        [Key]
        public Guid CampaignId { get; set; }

        public DateTime? ActualStart { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalActualCost { get; set; }

        [StringLength(256)]
        public string Message { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExpectedRevenue { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(32)]
        public string CodeName { get; set; }

        public DateTime? ProposedStart { get; set; }

        public string Objective { get; set; }

        public DateTime? ActualEnd { get; set; }

        public int StateCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherCost { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCampaignActivityActualCost { get; set; }

        public int? ExpectedResponse { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCampaignActivityActualCost_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? BudgetedCost_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExpectedRevenue_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherCost_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalActualCost_Base { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public Guid? StageId { get; set; }

        public Guid? ProcessId { get; set; }

        public Guid? EntityImageId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadBase> LeadBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityBase> OpportunityBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderBase> SalesOrderBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteBase> QuoteBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignItemBase> CampaignItemBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual PriceLevelBase PriceLevelBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
