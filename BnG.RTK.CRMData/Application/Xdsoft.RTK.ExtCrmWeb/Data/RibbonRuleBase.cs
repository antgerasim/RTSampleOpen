namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RibbonRuleBase")]
    public partial class RibbonRuleBase
    {
        [Key]
        [Column(Order = 0)]
        public DateTime OverwriteTime { get; set; }

        public int RuleType { get; set; }

        [StringLength(50)]
        public string Entity { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RibbonRuleId { get; set; }

        public Guid? RibbonCustomizationId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Required]
        public string RuleId { get; set; }

        public bool IsManaged { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid RibbonRuleUniqueId { get; set; }

        public string RuleDefinition { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        public Guid? SupportingSolutionId { get; set; }
    }
}
