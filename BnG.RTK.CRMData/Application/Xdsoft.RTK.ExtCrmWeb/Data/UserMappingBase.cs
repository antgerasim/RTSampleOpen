namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMappingBase")]
    public partial class UserMappingBase
    {
        public Guid? ModifiedBy { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Key]
        public Guid UserMappingId { get; set; }

        public int? PartnerApplicationType { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [StringLength(160)]
        public string SystemUserAttributeName { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(160)]
        public string ClaimType { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
