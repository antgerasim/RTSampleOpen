namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiteMapBase")]
    public partial class SiteMapBase
    {
        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime OverwriteTime { get; set; }

        public string SiteMapXmlManaged { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public Guid SiteMapIdUnique { get; set; }

        public string SiteMapXml { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SiteMapId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(200)]
        public string SiteMapName { get; set; }

        [StringLength(200)]
        public string SiteMapNameUnique { get; set; }

        public bool IsAppAware { get; set; }
    }
}
