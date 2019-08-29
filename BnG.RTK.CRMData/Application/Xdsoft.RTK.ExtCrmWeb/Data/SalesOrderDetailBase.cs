namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesOrderDetailBase")]
    public partial class SalesOrderDetailBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrderDetailBase()
        {
            SalesOrderDetailBase1 = new HashSet<SalesOrderDetailBase>();
        }

        [Key]
        public Guid SalesOrderDetailId { get; set; }

        public Guid SalesOrderId { get; set; }

        public Guid? SalesRepId { get; set; }

        public bool? IsProductOverridden { get; set; }

        public bool? IsCopied { get; set; }

        public decimal? QuantityShipped { get; set; }

        public int? LineItemNumber { get; set; }

        public decimal? QuantityBackordered { get; set; }

        public Guid? UoMId { get; set; }

        public decimal? QuantityCancelled { get; set; }

        public Guid? ProductId { get; set; }

        public DateTime? RequestDeliveryBy { get; set; }

        public decimal? Quantity { get; set; }

        public int? PricingErrorCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? ManualDiscountAmount { get; set; }

        [StringLength(500)]
        public string ProductDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? VolumeDiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? PricePerUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? BaseAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendedAmount { get; set; }

        public string Description { get; set; }

        public bool? IsPriceOverridden { get; set; }

        [StringLength(200)]
        public string ShipTo_Name { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tax { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(4000)]
        public string ShipTo_Line1 { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(4000)]
        public string ShipTo_Line2 { get; set; }

        [StringLength(4000)]
        public string ShipTo_Line3 { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(80)]
        public string ShipTo_City { get; set; }

        [StringLength(50)]
        public string ShipTo_StateOrProvince { get; set; }

        [StringLength(80)]
        public string ShipTo_Country { get; set; }

        [StringLength(20)]
        public string ShipTo_PostalCode { get; set; }

        public bool? WillCall { get; set; }

        [StringLength(50)]
        public string ShipTo_Telephone { get; set; }

        [StringLength(50)]
        public string ShipTo_Fax { get; set; }

        public int? ShipTo_FreightTermsCode { get; set; }

        [StringLength(150)]
        public string ShipTo_ContactName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ShipTo_AddressId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [Column(TypeName = "money")]
        public decimal? BaseAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? PricePerUnit_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? VolumeDiscountAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendedAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Tax_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? ManualDiscountAmount_Base { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? SequenceNumber { get; set; }

        public Guid? ProductAssociationId { get; set; }

        public Guid? ParentBundleId { get; set; }

        public int ProductTypeCode { get; set; }

        public int PropertyConfigurationStatus { get; set; }

        public virtual ProductAssociationBase ProductAssociationBase { get; set; }

        public virtual ProductBase ProductBase { get; set; }

        public virtual SalesOrderBase SalesOrderBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetailBase> SalesOrderDetailBase1 { get; set; }

        public virtual SalesOrderDetailBase SalesOrderDetailBase2 { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }

        public virtual UoMBase UoMBase { get; set; }
    }
}
