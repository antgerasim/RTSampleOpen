namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WizardAccessPrivilegeBase")]
    public partial class WizardAccessPrivilegeBase
    {
        public Guid? ModifiedBy { get; set; }

        [Required]
        [StringLength(100)]
        public string PrivilegeName { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid WebWizardId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Required]
        [StringLength(100)]
        public string EntityName { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [Key]
        public Guid WizardAccessPrivilegeId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual WebWizardBase WebWizardBase { get; set; }
    }
}
