namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FieldPermissionBase")]
    public partial class FieldPermissionBase
    {
        public Guid FieldPermissionIdUnique { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public int CanRead { get; set; }

        public bool IsManaged { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public int CanCreate { get; set; }

        public Guid FieldSecurityProfileId { get; set; }

        public int EntityName { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid FieldPermissionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int CanUpdate { get; set; }

        [Required]
        [StringLength(50)]
        public string AttributeLogicalName { get; set; }
    }
}
