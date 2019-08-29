namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractBase")]
    public partial class ContractBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractBase()
        {
            IncidentBase = new HashSet<IncidentBase>();
            ContractDetailBase = new HashSet<ContractDetailBase>();
            ContractBase1 = new HashSet<ContractBase>();
            ServiceContractContacts = new HashSet<ServiceContractContacts>();
        }

        [Key]
        public Guid ContractId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid ContractTemplateId { get; set; }

        public int? ContractServiceLevelCode { get; set; }

        public Guid? ServiceAddress { get; set; }

        public Guid? BillToAddress { get; set; }

        [StringLength(100)]
        public string ContractNumber { get; set; }

        public DateTime ActiveOn { get; set; }

        public DateTime ExpiresOn { get; set; }

        public DateTime? CancelOn { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public string ContractLanguage { get; set; }

        public DateTime? BillingStartOn { get; set; }

        [StringLength(168)]
        public string EffectivityCalendar { get; set; }

        public DateTime? BillingEndOn { get; set; }

        public int? BillingFrequencyCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? AllotmentTypeCode { get; set; }

        public bool? UseDiscountAsPercentage { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDiscount { get; set; }

        public int StateCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetPrice { get; set; }

        public int? StatusCode { get; set; }

        public Guid? OriginatingContract { get; set; }

        public int? Duration { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDiscount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetPrice_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice_Base { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? BillingCustomerId { get; set; }

        public int? CustomerIdType { get; set; }

        public int OwnerIdType { get; set; }

        public int? BillingCustomerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdName { get; set; }

        [StringLength(4000)]
        public string BillingCustomerIdName { get; set; }

        [StringLength(4000)]
        public string CustomerIdYomiName { get; set; }

        [StringLength(4000)]
        public string BillingCustomerIdYomiName { get; set; }

        public Guid? EntityImageId { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractDetailBase> ContractDetailBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBase> ContractBase1 { get; set; }

        public virtual ContractBase ContractBase2 { get; set; }

        public virtual ContractTemplateBaseIds ContractTemplateBaseIds { get; set; }

        public virtual CustomerAddressBase CustomerAddressBase { get; set; }

        public virtual CustomerAddressBase CustomerAddressBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceContractContacts> ServiceContractContacts { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
