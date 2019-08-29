namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebResourceBase")]
    public partial class WebResourceBase
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public bool IsManaged { get; set; }

        public int WebResourceType { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(20)]
        public string SilverlightVersion { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid WebResourceIdUnique { get; set; }

        [StringLength(200)]
        public string DisplayName { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool IsHidden { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid WebResourceId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool CanBeDeleted { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        public bool IsCustomizable { get; set; }

        public string Content { get; set; }

        public Guid? CreatedBy { get; set; }

        public string Description { get; set; }

        public int? LanguageCode { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public bool IsEnabledForMobileClient { get; set; }

        public string DependencyXml { get; set; }

        public bool IsAvailableForMobileOffline { get; set; }
    }
}
