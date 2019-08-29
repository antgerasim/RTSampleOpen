namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubscriptionManuallyTrackedObject")]
    public partial class SubscriptionManuallyTrackedObject
    {
        public Guid SubscriptionManuallyTrackedObjectId { get; set; }

        public Guid SubscriptionId { get; set; }

        public Guid ObjectId { get; set; }

        public bool Track { get; set; }

        public int? ObjectTypeCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual Subscription Subscription { get; set; }
    }
}
