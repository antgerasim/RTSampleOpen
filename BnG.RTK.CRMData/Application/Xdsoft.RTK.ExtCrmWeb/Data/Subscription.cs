namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subscription")]
    public partial class Subscription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subscription()
        {
            SubscriptionManuallyTrackedObject = new HashSet<SubscriptionManuallyTrackedObject>();
            SubscriptionSyncInfo = new HashSet<SubscriptionSyncInfo>();
            SubscriptionClients = new HashSet<SubscriptionClients>();
        }

        public Guid SubscriptionId { get; set; }

        public Guid SystemUserId { get; set; }

        [StringLength(200)]
        public string MachineName { get; set; }

        public DateTime? LastSyncStartedOn { get; set; }

        [Required]
        [StringLength(128)]
        public string SyncEntryTableName { get; set; }

        public int? SubscriptionType { get; set; }

        public DateTime? CompletedSyncStartedOn { get; set; }

        public bool ReInitialize { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public long? CompletedSyncVersionNumber { get; set; }

        [StringLength(48)]
        public string ClientVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriptionManuallyTrackedObject> SubscriptionManuallyTrackedObject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriptionSyncInfo> SubscriptionSyncInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriptionClients> SubscriptionClients { get; set; }
    }
}
