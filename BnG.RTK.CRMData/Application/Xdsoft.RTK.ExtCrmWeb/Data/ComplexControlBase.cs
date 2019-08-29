namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComplexControlBase")]
    public partial class ComplexControlBase
    {
        public int? Type { get; set; }

        public Guid OrganizationId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Key]
        public Guid ComplexControlId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid ComplexControlIdUnique { get; set; }

        [Required]
        public string ComplexControlXml { get; set; }

        public int? Version { get; set; }
    }
}
