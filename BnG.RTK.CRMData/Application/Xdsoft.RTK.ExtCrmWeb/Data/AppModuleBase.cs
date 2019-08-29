namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppModuleBase")]
    public partial class AppModuleBase
    {
        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? ModifiedBy { get; set; }

        public string Description { get; set; }

        public string ConfigXML { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public Guid WebResourceId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public Guid AppModuleIdUnique { get; set; }

        public bool? IsDefault { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool IsFeatured { get; set; }

        [StringLength(200)]
        public string URL { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid AppModuleId { get; set; }

        public bool? IsManaged { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string UniqueName { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? PublisherId { get; set; }

        public int? ClientType { get; set; }

        [StringLength(48)]
        public string AppModuleVersion { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? PublishedOn { get; set; }

        public int? FormFactor { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        [StringLength(100)]
        public string IntroducedVersion { get; set; }

        public string AppModuleXmlManaged { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}
