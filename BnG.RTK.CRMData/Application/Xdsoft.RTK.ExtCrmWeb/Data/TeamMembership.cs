namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeamMembership")]
    public partial class TeamMembership
    {
        public Guid TeamId { get; set; }

        public Guid SystemUserId { get; set; }

        public Guid TeamMembershipId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual TeamBase TeamBase { get; set; }
    }
}
