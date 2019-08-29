namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkflowDependencyBase")]
    public partial class WorkflowDependencyBase
    {
        [StringLength(256)]
        public string ParameterName { get; set; }

        [StringLength(50)]
        public string RelatedEntityName { get; set; }

        [StringLength(256)]
        public string RelatedAttributeName { get; set; }

        public Guid WorkflowId { get; set; }

        public Guid? SdkMessageId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int Type { get; set; }

        public string EntityAttributes { get; set; }

        [StringLength(50)]
        public string CustomEntityName { get; set; }

        [StringLength(50)]
        public string DependentEntityName { get; set; }

        [StringLength(100)]
        public string DependentAttributeName { get; set; }

        [Key]
        public Guid WorkflowDependencyId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(256)]
        public string ParameterType { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual WorkflowBaseIds WorkflowBaseIds { get; set; }
    }
}
