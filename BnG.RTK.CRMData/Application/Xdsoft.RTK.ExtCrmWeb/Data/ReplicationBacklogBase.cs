namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReplicationBacklogBase")]
    public partial class ReplicationBacklogBase
    {
        public Guid? TargetObjectId { get; set; }

        public string Data { get; set; }

        public int? ReplicationBacklogType { get; set; }

        public Guid? TargetDatacenterId { get; set; }

        [Key]
        public Guid ReplicationBacklogId { get; set; }

        public int? TargetObjectTypeCode { get; set; }
    }
}
