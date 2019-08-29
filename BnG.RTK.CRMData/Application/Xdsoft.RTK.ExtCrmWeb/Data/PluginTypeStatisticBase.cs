namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PluginTypeStatisticBase")]
    public partial class PluginTypeStatisticBase
    {
        public int TerminateMemoryContributionPercent { get; set; }

        public Guid OrganizationId { get; set; }

        public int AverageExecuteTimeInMilliseconds { get; set; }

        public int FailurePercent { get; set; }

        [Key]
        public Guid PluginTypeStatisticId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int CrashPercent { get; set; }

        public Guid? CreatedBy { get; set; }

        public int FailureCount { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int CrashCount { get; set; }

        public int CrashContributionPercent { get; set; }

        public int TerminateCpuContributionPercent { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int TerminateHandlesContributionPercent { get; set; }

        public Guid PluginTypeId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int ExecuteCount { get; set; }

        public int TerminateOtherContributionPercent { get; set; }

        public DateTime? CreatedOn { get; set; }

        public virtual PluginTypeBaseIds PluginTypeBaseIds { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual SystemUserBase SystemUserBase1 { get; set; }
    }
}
