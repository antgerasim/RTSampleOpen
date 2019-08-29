namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolePrivilegesBase")]
    public partial class RolePrivilegesBase
    {
        public Guid PrivilegeId { get; set; }

        public Guid RoleId { get; set; }

        public int PrivilegeDepthMask { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid RolePrivilegeId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public bool IsManaged { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid RolePrivilegeIdUnique { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }
    }
}
