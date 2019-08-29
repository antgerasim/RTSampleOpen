namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessTriggerBase")]
    public partial class ProcessTriggerBase
    {
        public Guid? CreatedBy { get; set; }

        public int? ControlType { get; set; }

        public Guid? FormId { get; set; }

        [StringLength(100)]
        public string ControlName { get; set; }

        public bool IsCustomizable { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime OverwriteTime { get; set; }

        public int PrimaryEntityTypeCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public Guid ProcessTriggerIdUnique { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Required]
        [StringLength(100)]
        public string Event { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid ProcessId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ProcessTriggerId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? MethodId { get; set; }

        public int Scope { get; set; }

        public int PipelineStage { get; set; }
    }
}
