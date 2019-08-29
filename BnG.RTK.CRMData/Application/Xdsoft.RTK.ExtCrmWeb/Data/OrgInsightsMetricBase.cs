namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrgInsightsMetricBase")]
    public partial class OrgInsightsMetricBase
    {
        public int? MetricType { get; set; }

        [StringLength(160)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid OrganizationId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(160)]
        public string InternalName { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OrgInsightsMetricId { get; set; }
    }
}
