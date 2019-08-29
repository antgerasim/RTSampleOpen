namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppModuleRolesBase")]
    public partial class AppModuleRolesBase
    {
        public Guid AppModuleId { get; set; }

        public Guid RoleId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid AppModuleRoleIdUnique { get; set; }

        public bool? IsManaged { get; set; }

        [StringLength(100)]
        public string IntroducedVersion { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AppModuleRoleId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }
    }
}
