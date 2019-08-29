namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TeamRoles
    {
        public Guid RoleId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid TeamId { get; set; }

        [Key]
        public Guid TeamRoleId { get; set; }

        public virtual RoleBaseIds RoleBaseIds { get; set; }

        public virtual TeamBase TeamBase { get; set; }
    }
}
