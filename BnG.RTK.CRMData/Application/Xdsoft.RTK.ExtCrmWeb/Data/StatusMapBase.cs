namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusMapBase")]
    public partial class StatusMapBase
    {
        public int ObjectTypeCode { get; set; }

        public Guid OrganizationId { get; set; }

        public int State { get; set; }

        public int Status { get; set; }

        public bool? IsDefault { get; set; }

        [Key]
        public Guid StatusMapId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }
    }
}
