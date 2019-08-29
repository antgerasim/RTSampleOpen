namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductBase")]
    public partial class ProductBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductBase()
        {
            CompetitorProduct = new HashSet<CompetitorProduct>();
            ContractDetailBase = new HashSet<ContractDetailBase>();
            EntitlementProducts = new HashSet<EntitlementProducts>();
            EntitlementTemplateProducts = new HashSet<EntitlementTemplateProducts>();
            IncidentBase = new HashSet<IncidentBase>();
            InvoiceDetailBase = new HashSet<InvoiceDetailBase>();
            LeadProduct = new HashSet<LeadProduct>();
            OpportunityProductBase = new HashSet<OpportunityProductBase>();
            ProductAssociationBase = new HashSet<ProductAssociationBase>();
            ProductAssociationBase1 = new HashSet<ProductAssociationBase>();
            SalesOrderDetailBase = new HashSet<SalesOrderDetailBase>();
            ProductBase1 = new HashSet<ProductBase>();
            ProductPriceLevelBase = new HashSet<ProductPriceLevelBase>();
            ProductSubstituteBase = new HashSet<ProductSubstituteBase>();
            ProductSubstituteBase1 = new HashSet<ProductSubstituteBase>();
            QuoteDetailBase = new HashSet<QuoteDetailBase>();
            RecommendationCacheBase = new HashSet<RecommendationCacheBase>();
            RecommendationCacheBase1 = new HashSet<RecommendationCacheBase>();
            ProductSalesLiterature = new HashSet<ProductSalesLiterature>();
        }

        [Key]
        public Guid ProductId { get; set; }

        public Guid? DefaultUoMScheduleId { get; set; }

        public Guid? SubjectId { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Guid? DefaultUoMId { get; set; }

        public Guid? PriceLevelId { get; set; }

        public string Description { get; set; }

        public int? ProductTypeCode { get; set; }

        [StringLength(255)]
        public string ProductUrl { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public bool? IsKit { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductNumber { get; set; }

        [StringLength(200)]
        public string Size { get; set; }

        [Column(TypeName = "money")]
        public decimal? CurrentCost { get; set; }

        public decimal? StockVolume { get; set; }

        [Column(TypeName = "money")]
        public decimal? StandardCost { get; set; }

        public decimal? StockWeight { get; set; }

        public int? QuantityDecimal { get; set; }

        public decimal? QuantityOnHand { get; set; }

        public bool? IsStockItem { get; set; }

        [StringLength(100)]
        public string SupplierName { get; set; }

        [StringLength(100)]
        public string VendorName { get; set; }

        [StringLength(100)]
        public string VendorPartNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public int StateCode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? StatusCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? CurrentCost_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? StandardCost_Base { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? StageId { get; set; }

        public Guid? ProcessId { get; set; }

        public Guid? EntityImageId { get; set; }

        public int ProductStructure { get; set; }

        [StringLength(100)]
        public string VendorID { get; set; }

        public Guid? ParentProductId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public DateTime? ValidToDate { get; set; }

        public DateTime? ValidFromDate { get; set; }

        [StringLength(900)]
        public string HierarchyPath { get; set; }

        public Guid? ModifiedByExternalParty { get; set; }

        public Guid? CreatedByExternalParty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetitorProduct> CompetitorProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractDetailBase> ContractDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementProducts> EntitlementProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitlementTemplateProducts> EntitlementTemplateProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetailBase> InvoiceDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeadProduct> LeadProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpportunityProductBase> OpportunityProductBase { get; set; }

        public virtual PriceLevelBase PriceLevelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductAssociationBase> ProductAssociationBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductAssociationBase> ProductAssociationBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetailBase> SalesOrderDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductBase> ProductBase1 { get; set; }

        public virtual ProductBase ProductBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductPriceLevelBase> ProductPriceLevelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSubstituteBase> ProductSubstituteBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSubstituteBase> ProductSubstituteBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteDetailBase> QuoteDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecommendationCacheBase> RecommendationCacheBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecommendationCacheBase> RecommendationCacheBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSalesLiterature> ProductSalesLiterature { get; set; }

        public virtual SubjectBase SubjectBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }

        public virtual UoMBase UoMBase { get; set; }

        public virtual UoMScheduleBase UoMScheduleBase { get; set; }
    }
}
