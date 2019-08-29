namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MailboxStatisticsBase")]
    public partial class MailboxStatisticsBase
    {
        public int? ItemsFailed { get; set; }

        public DateTime? MailboxProcessStartedOn { get; set; }

        public Guid OrganizationId { get; set; }

        public int? CrmItemsBacklog { get; set; }

        public Guid MailboxId { get; set; }

        [StringLength(160)]
        public string MachineName { get; set; }

        [Key]
        public Guid MailboxStatisticsId { get; set; }

        public DateTime? MailboxProcessCompletedOn { get; set; }

        public int? OperationTypeId { get; set; }

        public bool? ProcessResult { get; set; }

        public int? ItemsProcessed { get; set; }

        public DateTime? MailboxProcessScheduledOn { get; set; }

        [StringLength(160)]
        public string IndividualStepDurations { get; set; }

        public int? ScheduledTimeIntervalInMinutes { get; set; }

        public Guid? AsyncEventId { get; set; }

        public int? ProcessTimeIntervalInMinutes { get; set; }
    }
}
