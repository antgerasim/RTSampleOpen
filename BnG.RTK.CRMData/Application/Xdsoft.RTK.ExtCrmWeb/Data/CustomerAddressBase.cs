namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAddressBase")]
    public partial class CustomerAddressBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerAddressBase()
        {
            ContractBase = new HashSet<ContractBase>();
            ContractBase1 = new HashSet<ContractBase>();
            ContractDetailBase = new HashSet<ContractDetailBase>();
        }

        public Guid ParentId { get; set; }

        [Key]
        public Guid CustomerAddressId { get; set; }

        public int? AddressNumber { get; set; }

        public int ObjectTypeCode { get; set; }

        public int? AddressTypeCode { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(150)]
        public string PrimaryContactName { get; set; }

        [StringLength(4000)]
        public string Line1 { get; set; }

        [StringLength(4000)]
        public string Line2 { get; set; }

        [StringLength(4000)]
        public string Line3 { get; set; }

        [StringLength(4000)]
        public string City { get; set; }

        [StringLength(4000)]
        public string StateOrProvince { get; set; }

        [StringLength(4000)]
        public string County { get; set; }

        [StringLength(4000)]
        public string Country { get; set; }

        [StringLength(4000)]
        public string PostOfficeBox { get; set; }

        [StringLength(4000)]
        public string PostalCode { get; set; }

        public int? UTCOffset { get; set; }

        public int? FreightTermsCode { get; set; }

        [StringLength(4)]
        public string UPSZone { get; set; }

        public double? Latitude { get; set; }

        [StringLength(50)]
        public string Telephone1 { get; set; }

        public double? Longitude { get; set; }

        public int? ShippingMethodCode { get; set; }

        [StringLength(50)]
        public string Telephone2 { get; set; }

        [StringLength(50)]
        public string Telephone3 { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? ParentIdTypeCode { get; set; }

        public string Composite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBase> ContractBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBase> ContractBase1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractDetailBase> ContractDetailBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
