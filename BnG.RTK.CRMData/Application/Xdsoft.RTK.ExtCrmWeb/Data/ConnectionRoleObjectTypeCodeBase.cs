namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConnectionRoleObjectTypeCodeBase")]
    public partial class ConnectionRoleObjectTypeCodeBase
    {
        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int AssociatedObjectTypeCode { get; set; }

        public Guid ConnectionRoleId { get; set; }

        [Key]
        public Guid ConnectionRoleObjectTypeCodeId { get; set; }

        public virtual ConnectionRoleBaseIds ConnectionRoleBaseIds { get; set; }
    }
}
