namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OfficeDocumentBase")]
    public partial class OfficeDocumentBase
    {
        [StringLength(64)]
        public string SHA256 { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int DocumentType { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? ObjectId { get; set; }

        public string ClientData { get; set; }

        public int? FileLockState { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CreatedBy { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? FileSize { get; set; }

        public string Content { get; set; }

        [Key]
        public Guid OfficeDocumentId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? ObjectTypeCode { get; set; }

        public int OwnerIdType { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
