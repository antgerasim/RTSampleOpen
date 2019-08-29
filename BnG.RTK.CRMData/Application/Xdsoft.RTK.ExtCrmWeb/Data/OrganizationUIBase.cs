namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganizationUIBase")]
    public partial class OrganizationUIBase
    {
        [Key]
        [Column(Order = 0)]
        public Guid FormId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OrganizationId { get; set; }

        public string FormXml { get; set; }

        public string FieldXml { get; set; }

        public int? ObjectTypeCode { get; set; }

        public string PreviewXml { get; set; }

        public string PreviewColumnsetXml { get; set; }

        public int? Version { get; set; }

        public string OutlookShortcutIcon { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string GridIcon { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid FormIdUnique { get; set; }

        public string LargeEntityIcon { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid SolutionId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsCustomizable { get; set; }
    }
}
