namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BuildVersion")]
    public partial class BuildVersion
    {
        [Key]
        public DateTime BuildDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TimeStamp { get; set; }

        public int? BuildNumber { get; set; }

        public int? BuildQFE { get; set; }

        public int? MajorVersion { get; set; }

        public int? MinorVersion { get; set; }

        public int? Revision { get; set; }

        [StringLength(100)]
        public string LastDatabaseQfe { get; set; }

        [StringLength(20)]
        public string MinSupportedClient { get; set; }

        [StringLength(20)]
        public string MaxSupportedClient { get; set; }

        [StringLength(20)]
        public string MinSupportedRouter { get; set; }

        [StringLength(20)]
        public string MaxSupportedRouter { get; set; }

        public int? RevisionForMetadata { get; set; }

        public int? MajorVersionForMetadata { get; set; }

        public int? MinorVersionForMetadata { get; set; }

        public int? BuildNumberForMetadata { get; set; }

        public int? MajorVersionForMetadataForMetadata { get; set; }

        public int? MinorVersionForMetadataForMetadata { get; set; }

        public int? BuildNumberForMetadataForMetadata { get; set; }

        public int? RevisionForMetadataForMetadata { get; set; }
    }
}
