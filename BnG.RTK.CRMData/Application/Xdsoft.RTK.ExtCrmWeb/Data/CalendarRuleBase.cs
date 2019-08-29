namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CalendarRuleBase")]
    public partial class CalendarRuleBase
    {
        public bool? IsVaried { get; set; }

        public int Rank { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public string Description { get; set; }

        [Key]
        public Guid CalendarRuleId { get; set; }

        public double? Effort { get; set; }

        public DateTime? EndTime { get; set; }

        public int? TimeCode { get; set; }

        public DateTime? StartTime { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? Offset { get; set; }

        public bool? IsSimple { get; set; }

        [StringLength(160)]
        public string Name { get; set; }

        public int? TimeZoneCode { get; set; }

        public bool? IsSelected { get; set; }

        public int? ExtentCode { get; set; }

        public DateTime? EffectiveIntervalEnd { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid CalendarId { get; set; }

        public Guid? InnerCalendarId { get; set; }

        [StringLength(256)]
        public string Pattern { get; set; }

        [StringLength(36)]
        public string GroupDesignator { get; set; }

        public bool? IsModified { get; set; }

        public int? SubCode { get; set; }

        public int? Duration { get; set; }

        public DateTime? EffectiveIntervalStart { get; set; }

        public Guid? ServiceId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public virtual CalendarBase CalendarBase { get; set; }

        public virtual CalendarBase CalendarBase1 { get; set; }

        public virtual ServiceBase ServiceBase { get; set; }
    }
}
