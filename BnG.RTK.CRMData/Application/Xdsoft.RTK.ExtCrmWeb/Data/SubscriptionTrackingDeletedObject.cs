namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubscriptionTrackingDeletedObject")]
    public partial class SubscriptionTrackingDeletedObject
    {
        public int ObjectTypeCode { get; set; }

        public Guid ObjectId { get; set; }

        [Key]
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TimeStamp { get; set; }

        public DateTime? DeleteTime { get; set; }

        public bool? IsLogicalDelete { get; set; }
    }
}
