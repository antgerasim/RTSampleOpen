namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RibbonDiffBase")]
    public partial class RibbonDiffBase
    {
        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public string RDX { get; set; }

        public Guid RibbonDiffUniqueId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public Guid? RibbonCustomizationId { get; set; }

        public bool IsManaged { get; set; }

        [StringLength(50)]
        public string Entity { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RibbonDiffId { get; set; }

        public int? Sequence { get; set; }

        [Required]
        public string DiffId { get; set; }

        public Guid? ContextGroupId { get; set; }

        public Guid OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Required]
        public string TabId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public int DiffType { get; set; }

        public bool IsAppAware { get; set; }
    }
}
