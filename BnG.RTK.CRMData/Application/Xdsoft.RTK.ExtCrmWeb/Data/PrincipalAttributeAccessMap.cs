namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrincipalAttributeAccessMap")]
    public partial class PrincipalAttributeAccessMap
    {
        public Guid PrincipalId { get; set; }

        public int ReadAccess { get; set; }

        public int CreateAccess { get; set; }

        public Guid AttributeId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int UpdateAccess { get; set; }

        public Guid PrincipalAttributeAccessMapId { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
