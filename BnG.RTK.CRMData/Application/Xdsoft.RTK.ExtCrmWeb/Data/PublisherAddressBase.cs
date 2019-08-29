namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PublisherAddressBase")]
    public partial class PublisherAddressBase
    {
        [StringLength(4000)]
        public string Line1 { get; set; }

        [StringLength(4000)]
        public string Line3 { get; set; }

        public int? UTCOffset { get; set; }

        [StringLength(50)]
        public string Telephone2 { get; set; }

        public DateTime? CreatedOn { get; set; }

        public double? Longitude { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid PublisherAddressId { get; set; }

        public int? FreightTermsCode { get; set; }

        [StringLength(150)]
        public string PrimaryContactName { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(4000)]
        public string Line2 { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? ShippingMethodCode { get; set; }

        [StringLength(4000)]
        public string PostalCode { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(4000)]
        public string City { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public double? Latitude { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public int? AddressTypeCode { get; set; }

        [StringLength(50)]
        public string Telephone3 { get; set; }

        public Guid ParentId { get; set; }

        [StringLength(4000)]
        public string StateOrProvince { get; set; }

        [StringLength(4000)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Telephone1 { get; set; }

        [StringLength(4000)]
        public string PostOfficeBox { get; set; }

        public int? AddressNumber { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(4000)]
        public string County { get; set; }

        [StringLength(4)]
        public string UPSZone { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? ParentIdTypeCode { get; set; }
    }
}
