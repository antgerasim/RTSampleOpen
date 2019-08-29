namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrincipalEntityMap")]
    public partial class PrincipalEntityMap
    {
        public int ObjectTypeCode { get; set; }

        public Guid PrincipalId { get; set; }

        public Guid PrincipalEntityMapId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
