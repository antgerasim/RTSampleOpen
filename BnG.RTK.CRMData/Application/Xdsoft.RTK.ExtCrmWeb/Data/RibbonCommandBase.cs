namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RibbonCommandBase")]
    public partial class RibbonCommandBase
    {
        [StringLength(50)]
        public string Entity { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime OverwriteTime { get; set; }

        [Required]
        public string Command { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public string CommandDefinition { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RibbonCommandId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid RibbonCommandUniqueId { get; set; }

        public Guid? RibbonCustomizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }
    }
}
