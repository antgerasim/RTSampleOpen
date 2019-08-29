namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractDetailBase")]
    public partial class ContractDetailBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractDetailBase()
        {
            IncidentBase = new HashSet<IncidentBase>();
        }

        [Key]
        public Guid ContractDetailId { get; set; }

        public Guid? ServiceAddress { get; set; }

        public Guid? UoMId { get; set; }

        public Guid? ProductId { get; set; }

        [StringLength(100)]
        public string ProductSerialNumber { get; set; }

        public Guid ContractId { get; set; }

        public int? LineItemOrder { get; set; }

        public int? ServiceContractUnitsCode { get; set; }

        public int? InitialQuantity { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(168)]
        public string EffectivityCalendar { get; set; }

        public DateTime ActiveOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime ExpiresOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public int TotalAllotments { get; set; }

        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rate { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Net { get; set; }

        public int StateCode { get; set; }

        public int? AllotmentsRemaining { get; set; }

        public int? StatusCode { get; set; }

        public int? AllotmentsUsed { get; set; }

        public Guid? UoMScheduleId { get; set; }

        public decimal? DiscountPercentage { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discount_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Rate_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Net_Base { get; set; }

        public int? AllotmentsOverage { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? CustomerIdType { get; set; }

        [StringLength(4000)]
        public string CustomerIdName { get; set; }

        [StringLength(4000)]
        public string CustomerIdYomiName { get; set; }

        public virtual ContractBase ContractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentBase> IncidentBase { get; set; }

        public virtual UoMScheduleBase UoMScheduleBase { get; set; }

        public virtual CustomerAddressBase CustomerAddressBase { get; set; }

        public virtual ProductBase ProductBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }

        public virtual UoMBase UoMBase { get; set; }
    }
}
