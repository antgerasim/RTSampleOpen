namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DisplayStringBase")]
    public partial class DisplayStringBase
    {
        [StringLength(750)]
        public string PublishedDisplayString { get; set; }

        [StringLength(750)]
        public string CustomDisplayString { get; set; }

        [Required]
        [StringLength(200)]
        public string DisplayStringKey { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(500)]
        public string CustomComment { get; set; }

        public int FormatParameters { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public int? LanguageCode { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid DisplayStringId { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public bool IsManaged { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime OverwriteTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid DisplayStringIdUnique { get; set; }
    }
}
