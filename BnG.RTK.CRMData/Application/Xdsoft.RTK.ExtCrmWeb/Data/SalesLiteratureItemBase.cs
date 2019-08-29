namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesLiteratureItemBase")]
    public partial class SalesLiteratureItemBase
    {
        [Key]
        public Guid SalesLiteratureItemId { get; set; }

        public Guid SalesLiteratureId { get; set; }

        public bool? IsCustomerViewable { get; set; }

        [StringLength(500)]
        public string AttachedDocumentUrl { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(256)]
        public string MimeType { get; set; }

        [StringLength(500)]
        public string AuthorName { get; set; }

        public string Abstract { get; set; }

        public string DocumentBody { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string KeyWords { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        public int? FileTypeCode { get; set; }

        public int? FileSize { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual SalesLiteratureBase SalesLiteratureBase { get; set; }
    }
}
