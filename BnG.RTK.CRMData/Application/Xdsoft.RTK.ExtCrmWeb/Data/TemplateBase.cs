namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TemplateBase")]
    public partial class TemplateBase
    {
        [Key]
        [Column(Order = 0)]
        public Guid TemplateId { get; set; }

        public string Subject { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public bool? IsPersonal { get; set; }

        [StringLength(256)]
        public string MimeType { get; set; }

        public int TemplateTypeCode { get; set; }

        public string Body { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        public Guid? CreatedBy { get; set; }

        public string PresentationXml { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string SubjectPresentationXml { get; set; }

        public int? GenerationTypeCode { get; set; }

        public int? LanguageCode { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid TemplateIdUnique { get; set; }

        public bool IsManaged { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool IsCustomizable { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public Guid OwnerId { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public bool? IsRecommended { get; set; }

        public int? OpenCount { get; set; }

        public int? ReplyRate { get; set; }

        public int? ReplyCount { get; set; }

        public int? UsedCount { get; set; }

        public int? OpenRate { get; set; }
    }
}
