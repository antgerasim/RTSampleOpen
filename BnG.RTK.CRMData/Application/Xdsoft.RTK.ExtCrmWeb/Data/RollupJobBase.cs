namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RollupJobBase")]
    public partial class RollupJobBase
    {
        public Guid? RegardingObjectId { get; set; }

        public DateTime? PostponeUntil { get; set; }

        public int SourceEntityTypeCode { get; set; }

        public int? StatusCode { get; set; }

        [Key]
        public long RollupJobId { get; set; }

        public DateTime? RecordCreatedOn { get; set; }

        public int? StateCode { get; set; }

        public int? DepthProcessed { get; set; }

        public Guid RollupPropertiesId { get; set; }

        public int RetryCount { get; set; }

        public int? RegardingObjectTypeCode { get; set; }
    }
}
