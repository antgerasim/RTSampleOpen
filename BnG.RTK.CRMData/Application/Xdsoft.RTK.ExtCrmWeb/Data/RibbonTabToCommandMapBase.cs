namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RibbonTabToCommandMapBase")]
    public partial class RibbonTabToCommandMapBase
    {
        [Key]
        [Column(Order = 0)]
        public Guid SolutionId { get; set; }

        [Required]
        public string TabId { get; set; }

        public Guid RibbonTabToCommandMapUniqueId { get; set; }

        public string Command { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RibbonTabToCommandMapId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? RibbonDiffId { get; set; }

        public string ControlId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        public bool IsManaged { get; set; }

        [StringLength(50)]
        public string Entity { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }
    }
}
