namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttributeMapBase")]
    public partial class AttributeMapBase
    {
        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool IsSystem { get; set; }

        public Guid EntityMapId { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Required]
        [StringLength(50)]
        public string TargetAttributeName { get; set; }

        [Required]
        [StringLength(50)]
        public string SourceAttributeName { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? ParentAttributeMapId { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid AttributeMapId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid AttributeMapIdUnique { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }
    }
}
