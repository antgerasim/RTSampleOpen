namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleBase")]
    public partial class RoleBase
    {
        [Key]
        [Column(Order = 0)]
        public Guid RoleId { get; set; }

        public Guid? RoleTemplateId { get; set; }

        public Guid OrganizationId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Guid BusinessUnitId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? ParentRoleId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public bool IsManaged { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid RoleIdUnique { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool IsCustomizable { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid ParentRootRoleId { get; set; }
    }
}
