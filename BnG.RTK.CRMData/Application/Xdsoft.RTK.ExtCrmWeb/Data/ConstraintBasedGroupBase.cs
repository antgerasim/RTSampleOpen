namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConstraintBasedGroupBase")]
    public partial class ConstraintBasedGroupBase
    {
        public Guid? ModifiedBy { get; set; }

        public int GroupTypeCode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Key]
        public Guid ConstraintBasedGroupId { get; set; }

        public string Description { get; set; }

        [Required]
        public string Constraints { get; set; }

        public Guid BusinessUnitId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }
    }
}
