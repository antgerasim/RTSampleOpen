namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TopicModelConfigurationBase")]
    public partial class TopicModelConfigurationBase
    {
        public Guid TopicModelConfigurationIdUnique { get; set; }

        public decimal? MinRelevanceScore { get; set; }

        public bool IsManaged { get; set; }

        public DateTime OverwriteTime { get; set; }

        public int? SourceEntity { get; set; }

        public string FetchXmlList { get; set; }

        public string DataFilter { get; set; }

        public int? TimeFilter { get; set; }

        [Key]
        public Guid TopicModelConfigurationId { get; set; }

        public int? NgramSize { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Guid TopicModelId { get; set; }

        public int? TimeFilterDuration { get; set; }

        public int ComponentState { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid SolutionId { get; set; }

        public string Description { get; set; }

        [StringLength(500)]
        public string StopWords { get; set; }
    }
}
