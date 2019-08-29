namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attachment")]
    public partial class Attachment
    {
        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [StringLength(256)]
        public string MimeType { get; set; }

        public string Body { get; set; }

        [StringLength(2000)]
        public string Subject { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        public int? FileSize { get; set; }

        public Guid AttachmentId { get; set; }
    }
}
