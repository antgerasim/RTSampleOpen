namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolutionBase")]
    public partial class SolutionBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolutionBase()
        {
            DependencyNodeBase = new HashSet<DependencyNodeBase>();
            DependencyNodeBase1 = new HashSet<DependencyNodeBase>();
            SolutionBase1 = new HashSet<SolutionBase>();
            SolutionComponentBase = new HashSet<SolutionComponentBase>();
        }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(255)]
        public string PinpointAssetId { get; set; }

        [Required]
        [StringLength(65)]
        public string UniqueName { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OrganizationId { get; set; }

        public long? PinpointSolutionId { get; set; }

        [StringLength(16)]
        public string PinpointSolutionDefaultLocale { get; set; }

        [Key]
        public Guid SolutionId { get; set; }

        [Required]
        [StringLength(256)]
        public string FriendlyName { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool? IsVisible { get; set; }

        [Required]
        [StringLength(256)]
        public string Version { get; set; }

        public Guid? ConfigurationPageId { get; set; }

        public bool? IsManaged { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid PublisherId { get; set; }

        public DateTime? InstalledOn { get; set; }

        [StringLength(256)]
        public string SolutionPackageVersion { get; set; }

        public Guid? ParentSolutionId { get; set; }

        public bool? IsInternal { get; set; }

        public int? SolutionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DependencyNodeBase> DependencyNodeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DependencyNodeBase> DependencyNodeBase1 { get; set; }

        public virtual PublisherBase PublisherBase { get; set; }

        public virtual WebResourceBaseIds WebResourceBaseIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolutionBase> SolutionBase1 { get; set; }

        public virtual SolutionBase SolutionBase2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolutionComponentBase> SolutionComponentBase { get; set; }
    }
}
