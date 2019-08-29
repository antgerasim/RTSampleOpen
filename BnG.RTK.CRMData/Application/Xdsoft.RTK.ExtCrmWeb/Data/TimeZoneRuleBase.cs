namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeZoneRuleBase")]
    public partial class TimeZoneRuleBase
    {
        public Guid? ModifiedBy { get; set; }

        public int StandardDay { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int StandardMinute { get; set; }

        public int StandardBias { get; set; }

        public int StandardYear { get; set; }

        public int DaylightMonth { get; set; }

        public int StandardDayOfWeek { get; set; }

        public int DaylightSecond { get; set; }

        public int Bias { get; set; }

        public int TimeZoneRuleVersionNumber { get; set; }

        public int DaylightBias { get; set; }

        public int StandardMonth { get; set; }

        public DateTime EffectiveDateTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public int DaylightHour { get; set; }

        public int StandardHour { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int DaylightYear { get; set; }

        public int StandardSecond { get; set; }

        public int DaylightMinute { get; set; }

        public Guid TimeZoneDefinitionId { get; set; }

        public int DaylightDayOfWeek { get; set; }

        [Key]
        public Guid TimeZoneRuleId { get; set; }

        public int DaylightDay { get; set; }

        public Guid? OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public virtual TimeZoneDefinitionBase TimeZoneDefinitionBase { get; set; }
    }
}
