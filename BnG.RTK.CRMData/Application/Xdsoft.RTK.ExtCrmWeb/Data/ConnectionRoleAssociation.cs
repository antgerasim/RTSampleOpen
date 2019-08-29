namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConnectionRoleAssociation")]
    public partial class ConnectionRoleAssociation
    {
        public Guid AssociatedConnectionRoleId { get; set; }

        public Guid ConnectionRoleAssociationId { get; set; }

        public Guid ConnectionRoleId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual ConnectionRoleBaseIds ConnectionRoleBaseIds { get; set; }

        public virtual ConnectionRoleBaseIds ConnectionRoleBaseIds1 { get; set; }
    }
}
