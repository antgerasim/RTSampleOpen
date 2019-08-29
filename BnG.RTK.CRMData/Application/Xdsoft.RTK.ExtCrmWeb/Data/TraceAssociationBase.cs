namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraceAssociationBase")]
    public partial class TraceAssociationBase
    {
        public Guid RegardingObjectId { get; set; }

        public Guid TraceLogId { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        public Guid TraceAssociationId { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        public virtual TraceLogBase TraceLogBase { get; set; }
    }
}
