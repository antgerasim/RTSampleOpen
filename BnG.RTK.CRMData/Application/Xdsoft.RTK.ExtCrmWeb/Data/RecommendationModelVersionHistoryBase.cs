namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecommendationModelVersionHistoryBase")]
    public partial class RecommendationModelVersionHistoryBase
    {
        public string ErrorDetails { get; set; }

        public int? NumberRecordsSynchronized { get; set; }

        public int? ErrorCount { get; set; }

        [Key]
        public Guid RecommendationModelVersionHistoryId { get; set; }

        public int? WorkflowStepStatus { get; set; }

        public DateTime? StartTime { get; set; }

        public int? WorkflowStep { get; set; }

        public DateTime? EndTime { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid RecommendationModelVersionId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Duration { get; set; }

        public virtual RecommendationModelVersionBase RecommendationModelVersionBase { get; set; }
    }
}
