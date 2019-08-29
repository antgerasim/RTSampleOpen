namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PluginAssemblyBase")]
    public partial class PluginAssemblyBase
    {
        [StringLength(256)]
        public string SourceHash { get; set; }

        public int CustomizationLevel { get; set; }

        public string Content { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(256)]
        public string Path { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public Guid? CreatedBy { get; set; }

        [Required]
        [StringLength(48)]
        public string Version { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid PluginAssemblyId { get; set; }

        [Required]
        [StringLength(32)]
        public string Culture { get; set; }

        public int SourceType { get; set; }

        public Guid PluginAssemblyIdUnique { get; set; }

        [Required]
        [StringLength(32)]
        public string PublicKeyToken { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public int IsolationMode { get; set; }

        public int Minor { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public int Major { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        public bool IsHidden { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public bool IsCustomizable { get; set; }
    }
}
