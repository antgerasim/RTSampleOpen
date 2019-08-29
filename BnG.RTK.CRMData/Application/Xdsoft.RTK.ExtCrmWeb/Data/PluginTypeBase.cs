namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PluginTypeBase")]
    public partial class PluginTypeBase
    {
        [Required]
        [StringLength(256)]
        public string FriendlyName { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid PluginTypeId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid OrganizationId { get; set; }

        [Required]
        [StringLength(256)]
        public string TypeName { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool? IsWorkflowActivity { get; set; }

        public Guid PluginTypeIdUnique { get; set; }

        public Guid? PluginAssemblyId { get; set; }

        public int CustomizationLevel { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [StringLength(256)]
        public string Description { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [StringLength(256)]
        public string WorkflowActivityGroupName { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        public string CustomWorkflowActivityInfo { get; set; }
    }
}
