namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MetadataSyncTrackingDeletedObject")]
    public partial class MetadataSyncTrackingDeletedObject
    {
        public DateTime CreatedOn { get; set; }

        public int MetadataObjectTypeCode { get; set; }

        public Guid ObjectId { get; set; }

        [Key]
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
