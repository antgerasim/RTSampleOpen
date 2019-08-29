namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubscriptionSyncEntryOfflineBase")]
    public partial class SubscriptionSyncEntryOfflineBase
    {
        public byte SyncState { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SubscriptionId { get; set; }

        public long VersionNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectTypeCode { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ObjectId { get; set; }
    }
}
