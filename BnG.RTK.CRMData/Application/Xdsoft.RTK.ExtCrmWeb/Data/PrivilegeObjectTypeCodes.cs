namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PrivilegeObjectTypeCodes
    {
        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int ObjectTypeCode { get; set; }

        public Guid PrivilegeId { get; set; }

        [Key]
        public Guid PrivilegeObjectTypeCodeId { get; set; }

        public virtual PrivilegeBase PrivilegeBase { get; set; }
    }
}
