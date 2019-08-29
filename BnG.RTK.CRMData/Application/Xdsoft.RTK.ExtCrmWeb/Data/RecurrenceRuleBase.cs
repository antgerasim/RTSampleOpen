namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecurrenceRuleBase")]
    public partial class RecurrenceRuleBase
    {
        public int? Interval { get; set; }

        public DateTime? StartTime { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid OwnerId { get; set; }

        public int? MonthOfYear { get; set; }

        public int RecurrencePatternType { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool IsNthYearly { get; set; }

        public DateTime? PatternStartDate { get; set; }

        public int PatternEndType { get; set; }

        public bool IsNthMonthly { get; set; }

        public DateTime? EffectiveEndDate { get; set; }

        [Key]
        public Guid RuleId { get; set; }

        public int? FirstDayOfWeek { get; set; }

        public DateTime? PatternEndDate { get; set; }

        public DateTime? EndTime { get; set; }

        public int? Duration { get; set; }

        public int? DaysOfWeekMask { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsRegenerate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool IsWeekDayPattern { get; set; }

        public DateTime? EffectiveStartDate { get; set; }

        public Guid? ObjectId { get; set; }

        public int? Instance { get; set; }

        public int? DayOfMonth { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? Occurrences { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? ObjectTypeCode { get; set; }

        public int OwnerIdType { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
