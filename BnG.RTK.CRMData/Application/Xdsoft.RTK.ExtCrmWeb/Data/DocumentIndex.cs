namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentIndex")]
    public partial class DocumentIndex
    {
        public Guid DocumentIndexId { get; set; }

        public Guid SubjectId { get; set; }

        public Guid OrganizationId { get; set; }

        public bool? IsPublished { get; set; }

        public int DocumentTypeCode { get; set; }

        public Guid DocumentId { get; set; }

        [StringLength(500)]
        public string Location { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        public string KeyWords { get; set; }

        public string SearchText { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public bool? IsLatestVersion { get; set; }

        public virtual SubjectBase SubjectBase { get; set; }
    }
}
