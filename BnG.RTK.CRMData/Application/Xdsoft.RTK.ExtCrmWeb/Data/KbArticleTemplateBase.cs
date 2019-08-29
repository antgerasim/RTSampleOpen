namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KbArticleTemplateBase")]
    public partial class KbArticleTemplateBase
    {
        [Key]
        [Column(Order = 0)]
        public Guid KbArticleTemplateId { get; set; }

        public string StructureXml { get; set; }

        public Guid OrganizationId { get; set; }

        public string FormatXml { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string Description { get; set; }

        public bool? IsActive { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? LanguageCode { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public bool IsCustomizable { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid KbArticleTemplateIdUnique { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }
    }
}
