namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnnotationBase")]
    public partial class AnnotationBase
    {
        [Key]
        public Guid AnnotationId { get; set; }

        public int? ObjectTypeCode { get; set; }

        public Guid? ObjectId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        [StringLength(500)]
        public string Subject { get; set; }

        public bool IsDocument { get; set; }

        public string NoteText { get; set; }

        [StringLength(256)]
        public string MimeType { get; set; }

        [StringLength(2)]
        public string LangId { get; set; }

        public string DocumentBody { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? FileSize { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool? IsPrivate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(32)]
        public string StepId { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
