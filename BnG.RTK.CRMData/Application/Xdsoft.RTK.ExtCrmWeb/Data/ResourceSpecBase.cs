namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResourceSpecBase")]
    public partial class ResourceSpecBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ResourceSpecBase()
        {
            ServiceBase = new HashSet<ServiceBase>();
        }

        public double EffortRequired { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int ObjectTypeCode { get; set; }

        public string Description { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid BusinessUnitId { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Required]
        public string ObjectiveExpression { get; set; }

        public bool? SameSite { get; set; }

        public string Constraints { get; set; }

        [Key]
        public Guid ResourceSpecId { get; set; }

        public Guid GroupObjectId { get; set; }

        public int RequiredCount { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceBase> ServiceBase { get; set; }
    }
}
