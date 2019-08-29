namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemUserBusinessUnitEntityMap")]
    public partial class SystemUserBusinessUnitEntityMap
    {
        public int? ReadPrivilegeDepth { get; set; }

        public Guid SystemUserBusinessUnitEntityMapId { get; set; }

        public int ObjectTypeCode { get; set; }

        public Guid SystemUserId { get; set; }

        public Guid BusinessUnitId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }
    }
}
