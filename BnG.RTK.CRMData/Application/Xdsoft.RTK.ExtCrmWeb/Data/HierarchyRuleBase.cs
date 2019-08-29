namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HierarchyRuleBase")]
    public partial class HierarchyRuleBase
    {
        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Required]
        [StringLength(50)]
        public string RelatedEntityLogicalName { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid HierarchyRuleID { get; set; }

        public string Description { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimaryEntityLogicalName { get; set; }

        public Guid SortBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        public bool ShowDisabled { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool IsCustomizable { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public Guid? PrimaryEntityFormID { get; set; }

        public Guid? RelatedEntityFormId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public DateTime? PublishedOn { get; set; }

        public Guid HierarchyRuleIDUnique { get; set; }
    }
}
