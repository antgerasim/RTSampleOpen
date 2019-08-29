namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataPerformance")]
    public partial class DataPerformance
    {
        public decimal? Weight { get; set; }

        public string Entity { get; set; }

        public string Solution { get; set; }

        public string Component { get; set; }

        public Guid OrganizationId { get; set; }

        public string Operation { get; set; }

        public bool? OptimizationAvailable { get; set; }

        public Guid DataPerformanceId { get; set; }

        public decimal? OptimizationStorage { get; set; }

        public int? Count { get; set; }

        public decimal? MedianTime { get; set; }

        public DateTime? LastOptimizationDate { get; set; }

        public decimal? OptimizationImpact { get; set; }

        public decimal? MaxTime { get; set; }

        public decimal? MinTime { get; set; }

        [StringLength(50)]
        public string OptimizationStatus { get; set; }

        public bool? AnyOptimizationApplied { get; set; }

        [StringLength(50)]
        public string LastActionResult { get; set; }

        [StringLength(12)]
        public string ExecutionPeriod { get; set; }

        [StringLength(50)]
        public string RealizedOptimizationImpact { get; set; }
    }
}
