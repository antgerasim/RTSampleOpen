namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubscriptionSyncEntryOutlookBase")]
    public partial class SubscriptionSyncEntryOutlookBase
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectTypeCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ObjectId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SubscriptionId { get; set; }

        public long VersionNumber { get; set; }

        public byte SyncState { get; set; }
    }
}
