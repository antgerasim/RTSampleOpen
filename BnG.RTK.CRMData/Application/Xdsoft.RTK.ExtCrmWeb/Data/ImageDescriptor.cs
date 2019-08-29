namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageDescriptor")]
    public partial class ImageDescriptor
    {
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImageURL { get; set; }

        public int? ObjectTypeCode { get; set; }

        public Guid ImageDescriptorId { get; set; }

        public int? Size { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImageData { get; set; }

        [StringLength(256)]
        public string FileType { get; set; }

        public long? ImageTimestamp { get; set; }

        public Guid? ObjectId { get; set; }
    }
}
