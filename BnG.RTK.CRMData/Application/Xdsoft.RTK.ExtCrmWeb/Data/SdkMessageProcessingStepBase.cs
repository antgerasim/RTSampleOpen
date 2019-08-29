namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SdkMessageProcessingStepBase")]
    public partial class SdkMessageProcessingStepBase
    {
        public DateTime? CreatedOn { get; set; }

        public string Configuration { get; set; }

        public int SupportedDeployment { get; set; }

        public Guid PluginTypeId { get; set; }

        public int Rank { get; set; }

        public Guid SdkMessageId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SdkMessageProcessingStepId { get; set; }

        public int Stage { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid SdkMessageProcessingStepIdUnique { get; set; }

        public string FilteringAttributes { get; set; }

        public int CustomizationLevel { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int StateCode { get; set; }

        public Guid? SdkMessageProcessingStepSecureConfigId { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int Mode { get; set; }

        public Guid? SdkMessageFilterId { get; set; }

        public int? StatusCode { get; set; }

        public Guid? ImpersonatingUserId { get; set; }

        public int InvocationSource { get; set; }

        public bool AsyncAutoDelete { get; set; }

        public bool IsCustomizable { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public bool IsManaged { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public Guid? EventHandler { get; set; }

        public bool IsHidden { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? EventHandlerTypeCode { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public bool CanUseReadOnlyConnection { get; set; }
    }
}
