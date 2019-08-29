namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemUserManagerMap")]
    public partial class SystemUserManagerMap
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HierarchyLevel { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SystemUserManagerMapId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ParentSystemUserId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SystemUserId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }
    }
}
