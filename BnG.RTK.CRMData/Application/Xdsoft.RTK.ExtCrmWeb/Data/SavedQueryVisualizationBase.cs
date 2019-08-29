namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SavedQueryVisualizationBase")]
    public partial class SavedQueryVisualizationBase
    {
        [Key]
        [Column(Order = 0)]
        public DateTime OverwriteTime { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public string Description { get; set; }

        public string PresentationDescription { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool IsDefault { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string DataDescription { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid SavedQueryVisualizationIdUnique { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool IsCustomizable { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SavedQueryVisualizationId { get; set; }

        public int PrimaryEntityTypeCode { get; set; }

        public Guid? WebResourceId { get; set; }

        public bool IsManaged { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public bool CanBeDeleted { get; set; }

        public int? Type { get; set; }

        public int ChartType { get; set; }
    }
}
