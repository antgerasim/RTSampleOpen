namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemFormBase")]
    public partial class SystemFormBase
    {
        public string FormXmlManaged { get; set; }

        public int? Version { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid FormId { get; set; }

        public DateTime? PublishedOn { get; set; }

        [Required]
        public string FormXml { get; set; }

        public bool CanBeDeleted { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public bool IsCustomizable { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        public bool IsManaged { get; set; }

        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Guid? AncestorFormId { get; set; }

        public int? Type { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ObjectTypeCode { get; set; }

        public Guid FormIdUnique { get; set; }

        public bool IsDefault { get; set; }

        public int FormPresentation { get; set; }

        public int FormActivationState { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public bool? IsAIRMerged { get; set; }

        public bool IsTabletEnabled { get; set; }

        [StringLength(200)]
        public string UniqueName { get; set; }

        public bool IsDesktopEnabled { get; set; }
    }
}
