namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityMimeAttachment")]
    public partial class ActivityMimeAttachment
    {
        public int AttachmentNumber { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ActivityMimeAttachmentId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public Guid? AttachmentId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public int ObjectTypeCode { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        public Guid ActivityMimeAttachmentIdUnique { get; set; }

        public Guid ObjectId { get; set; }

        [StringLength(250)]
        public string AttachmentContentId { get; set; }

        [StringLength(2000)]
        public string AnonymousLink { get; set; }

        public bool? IsFollowed { get; set; }
    }
}
