namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrivilegeBase")]
    public partial class PrivilegeBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrivilegeBase()
        {
            PrivilegeObjectTypeCodes = new HashSet<PrivilegeObjectTypeCodes>();
            RoleTemplatePrivileges = new HashSet<RoleTemplatePrivileges>();
        }

        [Key]
        public Guid PrivilegeId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? CanBeLocal { get; set; }

        public bool? CanBeDeep { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool? CanBeGlobal { get; set; }

        public bool? CanBeBasic { get; set; }

        public int? AccessRight { get; set; }

        public bool IsDisabledWhenIntegrated { get; set; }

        public bool CanBeEntityReference { get; set; }

        public bool CanBeParentEntityReference { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrivilegeObjectTypeCodes> PrivilegeObjectTypeCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleTemplatePrivileges> RoleTemplatePrivileges { get; set; }
    }
}
