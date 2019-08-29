namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebWizardBase")]
    public partial class WebWizardBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebWizardBase()
        {
            WizardAccessPrivilegeBase = new HashSet<WizardAccessPrivilegeBase>();
            WizardPageBase = new HashSet<WizardPageBase>();
        }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        [Key]
        public Guid WebWizardId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? WizardPageHeight { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? WizardPageWidth { get; set; }

        public int? StartPageSequenceNumber { get; set; }

        [StringLength(1024)]
        public string AccessPrivileges { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleResourceString { get; set; }

        public bool IsStaticPageSequence { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WizardAccessPrivilegeBase> WizardAccessPrivilegeBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WizardPageBase> WizardPageBase { get; set; }
    }
}
