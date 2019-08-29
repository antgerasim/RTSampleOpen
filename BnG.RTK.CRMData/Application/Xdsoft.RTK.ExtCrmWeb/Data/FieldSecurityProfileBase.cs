namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FieldSecurityProfileBase")]
    public partial class FieldSecurityProfileBase
    {
        public string Description { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool IsManaged { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid? CreatedBy { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid FieldSecurityProfileId { get; set; }

        public Guid FieldSecurityProfileIdUnique { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? SupportingSolutionId { get; set; }
    }
}
