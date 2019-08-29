namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SdkMessageProcessingStepImageBase")]
    public partial class SdkMessageProcessingStepImageBase
    {
        public Guid? ModifiedBy { get; set; }

        public Guid? SdkMessageProcessingStepId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SdkMessageProcessingStepImageId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Required]
        [StringLength(256)]
        public string EntityAlias { get; set; }

        public int CustomizationLevel { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid SdkMessageProcessingStepImageIdUnique { get; set; }

        public int ImageType { get; set; }

        [StringLength(256)]
        public string RelatedAttributeName { get; set; }

        [Required]
        [StringLength(256)]
        public string MessagePropertyName { get; set; }

        public string Attributes { get; set; }

        public bool IsCustomizable { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        public bool IsManaged { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }
    }
}
