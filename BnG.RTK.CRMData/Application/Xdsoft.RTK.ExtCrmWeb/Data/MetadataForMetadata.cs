namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MetadataForMetadata")]
    public partial class MetadataForMetadata
    {
        public DateTime InstalledOn { get; set; }

        [Key]
        public Guid MetadataForMetadataXmlId { get; set; }

        [Required]
        public string MetadataForMetadataXml { get; set; }

        [Required]
        [StringLength(50)]
        public string BuildVersion { get; set; }
    }
}
