namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResourceBase")]
    public partial class ResourceBase
    {
        public bool? DisplayInServiceViews { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectTypeCode { get; set; }

        public Guid BusinessUnitId { get; set; }

        public Guid? CalendarId { get; set; }

        public bool? IsDisabled { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ResourceId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(160)]
        public string Name { get; set; }

        public Guid? SiteId { get; set; }

        public Guid? EntityImageId { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual SiteBase SiteBase { get; set; }
    }
}
