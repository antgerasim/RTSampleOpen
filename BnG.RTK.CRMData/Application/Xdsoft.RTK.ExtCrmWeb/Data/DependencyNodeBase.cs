namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DependencyNodeBase")]
    public partial class DependencyNodeBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DependencyNodeBase()
        {
            DependencyBase = new HashSet<DependencyBase>();
            DependencyBase1 = new HashSet<DependencyBase>();
        }

        public Guid? BaseSolutionId { get; set; }

        public Guid? TopSolutionId { get; set; }

        public Guid? ParentId { get; set; }

        [Key]
        public Guid DependencyNodeId { get; set; }

        public int ComponentType { get; set; }

        public Guid? ObjectId { get; set; }

        public bool? IsSharedComponent { get; set; }

        public double? IntroducedVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DependencyBase> DependencyBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DependencyBase> DependencyBase1 { get; set; }

        public virtual SolutionBase SolutionBase { get; set; }

        public virtual SolutionBase SolutionBase1 { get; set; }
    }
}
