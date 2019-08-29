namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiteBase")]
    public partial class SiteBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SiteBase()
        {
            ActivityPointerBase = new HashSet<ActivityPointerBase>();
            EquipmentBase = new HashSet<EquipmentBase>();
            ResourceBase = new HashSet<ResourceBase>();
            SystemUserBase = new HashSet<SystemUserBase>();
        }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(100)]
        public string EMailAddress { get; set; }

        [Required]
        [StringLength(160)]
        public string Name { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        public Guid SiteId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int TimeZoneCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPointerBase> ActivityPointerBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentBase> EquipmentBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResourceBase> ResourceBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUserBase> SystemUserBase { get; set; }
    }
}
