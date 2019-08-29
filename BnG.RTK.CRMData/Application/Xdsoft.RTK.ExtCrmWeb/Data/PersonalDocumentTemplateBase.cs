namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonalDocumentTemplateBase")]
    public partial class PersonalDocumentTemplateBase
    {
        public bool? Status { get; set; }

        public int? AssociatedEntityTypeCode { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [Required]
        public string Content { get; set; }

        public string Description { get; set; }

        public string ClientData { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int DocumentType { get; set; }

        public int LanguageCode { get; set; }

        [Key]
        public Guid PersonalDocumentTemplateId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }
    }
}
