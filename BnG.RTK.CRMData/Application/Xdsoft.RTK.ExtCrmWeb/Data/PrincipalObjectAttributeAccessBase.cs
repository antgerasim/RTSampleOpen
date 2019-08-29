namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrincipalObjectAttributeAccessBase")]
    public partial class PrincipalObjectAttributeAccessBase
    {
        public Guid ObjectId { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid PrincipalId { get; set; }

        public Guid AttributeId { get; set; }

        public bool ReadAccess { get; set; }

        [Key]
        public Guid PrincipalObjectAttributeAccessId { get; set; }

        public bool UpdateAccess { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int PrincipalIdType { get; set; }

        public int ObjectTypeCode { get; set; }
    }
}
