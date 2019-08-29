namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessUnitMap")]
    public partial class BusinessUnitMap
    {
        public Guid BusinessUnitMapId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid SubBusinessId { get; set; }

        public Guid BusinessId { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase1 { get; set; }
    }
}
