namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RibbonContextGroupBase")]
    public partial class RibbonContextGroupBase
    {
        [Key]
        [Column(Order = 0)]
        public DateTime OverwriteTime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        public bool IsManaged { get; set; }

        [StringLength(50)]
        public string Entity { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RibbonContextGroupId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public string ContextGroupXml { get; set; }

        public Guid RibbonContextGroupUniqueId { get; set; }

        [Required]
        public string ContextGroupId { get; set; }

        public Guid? RibbonCustomizationId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }
    }
}
