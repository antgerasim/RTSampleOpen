namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartnerApplicationBase")]
    public partial class PartnerApplicationBase
    {
        public DateTime? CreatedOn { get; set; }

        public int StateCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(1024)]
        public string MetadataUrl { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public bool? UseAuthorizationServer { get; set; }

        [Required]
        [StringLength(100)]
        public string PrincipalId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(256)]
        public string Realm { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        public Guid PartnerApplicationId { get; set; }

        public int? StatusCode { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int ApplicationRole { get; set; }

        public Guid? TenantId { get; set; }
    }
}
