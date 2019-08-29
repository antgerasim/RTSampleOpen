namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HierarchySecurityConfiguration")]
    public partial class HierarchySecurityConfiguration
    {
        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(64)]
        public string EntityName { get; set; }

        public int ObjectTypeCode { get; set; }

        [Key]
        public Guid HierarchySecurityModelingSettingId { get; set; }
    }
}
