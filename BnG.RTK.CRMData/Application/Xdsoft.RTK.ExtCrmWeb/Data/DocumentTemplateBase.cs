namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentTemplateBase")]
    public partial class DocumentTemplateBase
    {
        public Guid? CreatedBy { get; set; }

        [Required]
        public string Content { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? AssociatedEntityTypeCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int DocumentType { get; set; }

        [Key]
        public Guid DocumentTemplateId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string ClientData { get; set; }

        public int LanguageCode { get; set; }

        public string Description { get; set; }

        public Guid OrganizationId { get; set; }

        public bool? Status { get; set; }
    }
}
