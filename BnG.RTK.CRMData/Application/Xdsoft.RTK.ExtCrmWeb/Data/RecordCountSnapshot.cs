namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordCountSnapshot")]
    public partial class RecordCountSnapshot
    {
        public long Count { get; set; }

        public Guid RecordCountSnapshotId { get; set; }

        public int ObjectTypeCode { get; set; }
    }
}
