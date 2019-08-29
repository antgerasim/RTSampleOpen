namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailSignatureBase")]
    public partial class EmailSignatureBase
    {
        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime OverwriteTime { get; set; }

        public Guid OwnerId { get; set; }

        public string PresentationXml { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? CreatedBy { get; set; }

        public string Body { get; set; }

        public bool IsCustomizable { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public bool? IsDefault { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? LanguageCode { get; set; }

        [Key]
        public Guid EmailSignatureId { get; set; }

        public bool? IsPersonal { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(256)]
        public string MimeType { get; set; }

        public string Description { get; set; }

        public int? GenerationTypeCode { get; set; }

        public int ComponentState { get; set; }

        public int OwnerIdType { get; set; }
    }
}
