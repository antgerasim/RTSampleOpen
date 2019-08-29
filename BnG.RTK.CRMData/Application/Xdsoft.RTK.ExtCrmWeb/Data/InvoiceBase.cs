namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceBase")]
    public partial class InvoiceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvoiceBase()
        {
            ContactInvoices = new HashSet<ContactInvoices>();
            InvoiceDetailBase = new HashSet<InvoiceDetailBase>();
        }

        [Key]
        public Guid InvoiceId { get; set; }

        public Guid? OpportunityId { get; set; }

        public int? PriorityCode { get; set; }

        public Guid? SalesOrderId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public DateTime? LastBackofficeSubmit { get; set; }

        public Guid? PriceLevelId { get; set; }

        [Required]
        [StringLength(100)]
        public string InvoiceNumber { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FreightAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLineItemAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLineItemDiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmountLessFreight { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDiscountAmount { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTax { get; set; }

        public int? ShippingMethodCode { get; set; }

        public int? PaymentTermsCode { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int StateCode { get; set; }

        public int? StatusCode { get; set; }

        [StringLength(200)]
        public string ShipTo_Name { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? PricingErrorCode { get; set; }

        [StringLength(4000)]
        public string ShipTo_Line1 { get; set; }

        [StringLength(4000)]
        public string ShipTo_Line2 { get; set; }

        [StringLength(4000)]
        public string ShipTo_Line3 { get; set; }

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

        [StringLength(200)]
        public string BillTo_Name { get; set; }

        public int? ShipTo_FreightTermsCode { get; set; }

        [StringLength(50)]
        public string ShipTo_Fax { get; set; }

        [StringLength(4000)]
        public string BillTo_Line1 { get; set; }

        [StringLength(4000)]
        public string BillTo_Line2 { get; set; }

        [StringLength(4000)]
        public string BillTo_Line3 { get; set; }

        [StringLength(80)]
        public string BillTo_City { get; set; }

        [StringLength(50)]
        public string BillTo_StateOrProvince { get; set; }

        [StringLength(80)]
        public string BillTo_Country { get; set; }

        [StringLength(20)]
        public string BillTo_PostalCode { get; set; }

        [StringLength(50)]
        public string BillTo_Telephone { get; set; }

        [StringLength(50)]
        public string BillTo_Fax { get; set; }

        public decimal? DiscountPercentage { get; set; }

        public bool? IsPriceLocked { get; set; }

        public DateTime? DateDelivered { get; set; }

        public DateTime? DueDate { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLineItemAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLineItemDiscountAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTax_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmountLessFreight_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? FreightAmount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDiscountAmount_Base { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CustomerId { get; set; }

        public int? CustomerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdName { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdYomiName { get; set; }

        public Guid? ProcessId { get; set; }

        public string ShipTo_Composite { get; set; }

        public Guid? StageId { get; set; }

        public string BillTo_Composite { get; set; }

        public Guid? EntityImageId { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public int? OnHoldTime { get; set; }

        public DateTime? LastOnHoldTime { get; set; }

        public Guid? SLAInvokedId { get; set; }

        public Guid? SLAId { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactInvoices> ContactInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetailBase> InvoiceDetailBase { get; set; }

        public virtual SLABaseIds SLABaseIds { get; set; }

        public virtual OpportunityBase OpportunityBase { get; set; }

        public virtual SalesOrderBase SalesOrderBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual PriceLevelBase PriceLevelBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
