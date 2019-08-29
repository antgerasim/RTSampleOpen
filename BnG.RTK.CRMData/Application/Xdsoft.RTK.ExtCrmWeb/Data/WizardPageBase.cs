namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WizardPageBase")]
    public partial class WizardPageBase
    {
        public int PageSequenceNumber { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid OrganizationId { get; set; }

        [Required]
        [StringLength(512)]
        public string PageUrl { get; set; }

        public Guid WebWizardId { get; set; }

        [Key]
        public Guid WizardPageId { get; set; }

        [StringLength(1024)]
        public string PageDataToPost { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public virtual WebWizardBase WebWizardBase { get; set; }
    }
}
