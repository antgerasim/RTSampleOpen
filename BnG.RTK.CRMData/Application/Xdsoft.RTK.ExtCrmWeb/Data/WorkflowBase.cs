namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkflowBase")]
    public partial class WorkflowBase
    {
        public bool? OnDemand { get; set; }

        public string Activities { get; set; }

        public Guid? PluginTypeId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int Type { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid WorkflowId { get; set; }

        public Guid? ActiveWorkflowId { get; set; }

        public Guid? ParentWorkflowId { get; set; }

        public string UIData { get; set; }

        public int PrimaryEntity { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsCrmUIWorkflow { get; set; }

        public bool? Subprocess { get; set; }

        public int Scope { get; set; }

        public int? StatusCode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public string Rules { get; set; }

        public string Description { get; set; }

        public Guid? CreatedBy { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int StateCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        public bool? TriggerOnCreate { get; set; }

        public bool AsyncAutoDelete { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public string InputParameters { get; set; }

        public string Xaml { get; set; }

        public int Category { get; set; }

        public int? LanguageCode { get; set; }

        public bool? TriggerOnDelete { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool IsCustomizable { get; set; }

        public string TriggerOnUpdateAttributeList { get; set; }

        public Guid WorkflowIdUnique { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid OwnerId { get; set; }

        public bool IsManaged { get; set; }

        public int OwnerIdType { get; set; }

        [StringLength(256)]
        public string UniqueName { get; set; }

        public int? ProcessOrder { get; set; }

        public int? Rank { get; set; }

        public int? CreateStage { get; set; }

        public string ProcessRoleAssignment { get; set; }

        public int? RunAs { get; set; }

        public bool? IsTransacted { get; set; }

        public bool SyncWorkflowLogOnFailure { get; set; }

        public int? DeleteStage { get; set; }

        public int Mode { get; set; }

        public int? UpdateStage { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? SdkMessageId { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public string ClientData { get; set; }

        public int? RendererObjectTypeCode { get; set; }

        public Guid? EntityImageId { get; set; }

        public Guid? FormId { get; set; }

        public int? BusinessProcessType { get; set; }
    }
}
