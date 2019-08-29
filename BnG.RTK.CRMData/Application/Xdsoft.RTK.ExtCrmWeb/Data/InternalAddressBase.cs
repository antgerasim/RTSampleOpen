namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InternalAddressBase")]
    public partial class InternalAddressBase
    {
        public Guid ParentId { get; set; }

        [Key]
        public Guid InternalAddressId { get; set; }

        public int? AddressNumber { get; set; }

        public int ObjectTypeCode { get; set; }

        public int? AddressTypeCode { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

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

        [StringLength(4)]
        public string UPSZone { get; set; }

        public double? Latitude { get; set; }

        [StringLength(64)]
        public string Telephone1 { get; set; }

        public double? Longitude { get; set; }

        public int? ShippingMethodCode { get; set; }

        [StringLength(50)]
        public string Telephone2 { get; set; }

        [StringLength(50)]
        public string Telephone3 { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(64)]
        public string Fax { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public string Composite { get; set; }
    }
}
