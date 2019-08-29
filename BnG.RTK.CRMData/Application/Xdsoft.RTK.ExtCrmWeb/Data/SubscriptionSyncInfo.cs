namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubscriptionSyncInfo")]
    public partial class SubscriptionSyncInfo
    {
        public DateTime? EndTime { get; set; }

        public int SubscriptionSyncInfoId { get; set; }

        public int? DeleteObjectCount { get; set; }

        public Guid? SubscriptionId { get; set; }

        public bool? SyncResult { get; set; }

        public DateTime? StartTime { get; set; }

        public int? DataSize { get; set; }

        public int? InsertObjectCount { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(20)]
        public string ClientVersion { get; set; }

        public virtual Subscription Subscription { get; set; }
    }
}
