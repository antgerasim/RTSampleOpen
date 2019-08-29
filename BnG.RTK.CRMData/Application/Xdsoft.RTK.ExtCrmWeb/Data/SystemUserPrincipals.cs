namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemUserPrincipals
    {
        [Key]
        public Guid SystemUserPrincipalId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid PrincipalId { get; set; }

        public Guid SystemUserId { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }
    }
}
