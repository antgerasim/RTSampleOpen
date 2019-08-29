namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RollupFieldBase")]
    public partial class RollupFieldBase
    {
        public Guid? CreatedBy { get; set; }

        public Guid? MetricId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(100)]
        public string SourceAttribute { get; set; }

        public int? SourceState { get; set; }

        [StringLength(100)]
        public string GoalAttribute { get; set; }

        public int? SourceEntity { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? SourceStatus { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(100)]
        public string DateAttribute { get; set; }

        public bool? IsStateParentEntityAttribute { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? EntityForDateAttribute { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [Key]
        public Guid RollupFieldId { get; set; }

        public virtual MetricBase MetricBase { get; set; }
    }
}
