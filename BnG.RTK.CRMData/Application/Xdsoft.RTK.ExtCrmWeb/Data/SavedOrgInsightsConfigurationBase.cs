namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SavedOrgInsightsConfigurationBase")]
    public partial class SavedOrgInsightsConfigurationBase
    {
        public int? Lookback { get; set; }

        public bool IsDefault { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool IsDrilldown { get; set; }

        public string JsonData { get; set; }

        [Key]
        public Guid SavedOrgInsightsConfigurationId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public string Description { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string Parameters { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? JsonDataEndTime { get; set; }

        public DateTime? JsonDataStartTime { get; set; }

        public Guid? ModifiedBy { get; set; }

        public string Name { get; set; }

        public int? MetricType { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? PlotOption { get; set; }
    }
}
