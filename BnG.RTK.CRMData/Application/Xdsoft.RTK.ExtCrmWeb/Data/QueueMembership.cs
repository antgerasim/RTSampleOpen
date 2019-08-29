namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QueueMembership")]
    public partial class QueueMembership
    {
        public Guid QueueId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid QueueMembershipId { get; set; }

        public Guid SystemUserId { get; set; }

        public virtual QueueBase QueueBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }
    }
}
