namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolutionComponentBase")]
    public partial class SolutionComponentBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolutionComponentBase()
        {
            SolutionComponentBase1 = new HashSet<SolutionComponentBase>();
        }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ObjectId { get; set; }

        public bool? IsMetadata { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? SolutionId { get; set; }

        [Key]
        public Guid SolutionComponentId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int ComponentType { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? RootComponentBehavior { get; set; }

        public Guid? RootSolutionComponentId { get; set; }

        public virtual SolutionBase SolutionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolutionComponentBase> SolutionComponentBase1 { get; set; }

        public virtual SolutionComponentBase SolutionComponentBase2 { get; set; }
    }
}
