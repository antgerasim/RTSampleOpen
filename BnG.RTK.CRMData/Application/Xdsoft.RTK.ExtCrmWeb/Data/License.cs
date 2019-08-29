namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("License")]
    public partial class License
    {
        public Guid LicenseId { get; set; }

        public Guid OrganizationId { get; set; }

        [Required]
        [StringLength(100)]
        public string LicenseKey { get; set; }

        public DateTime InstalledOn { get; set; }

        public Guid? LicenseType { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }
    }
}
