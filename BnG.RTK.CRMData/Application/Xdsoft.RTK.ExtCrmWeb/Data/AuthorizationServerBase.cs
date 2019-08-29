namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuthorizationServerBase")]
    public partial class AuthorizationServerBase
    {
        public int StateCode { get; set; }

        public Guid OrganizationId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(100)]
        public string Realm { get; set; }

        [Required]
        [StringLength(100)]
        public string PrincipalId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid? TenantId { get; set; }

        [StringLength(1024)]
        public string MetadataUrl { get; set; }

        public int? StatusCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        public Guid AuthorizationServerId { get; set; }

        public DateTime? MetadataRefreshedOn { get; set; }

        public string Metadata { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? AuthorizationServerType { get; set; }
    }
}
