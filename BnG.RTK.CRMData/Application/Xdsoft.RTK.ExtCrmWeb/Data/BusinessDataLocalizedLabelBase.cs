namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessDataLocalizedLabelBase")]
    public partial class BusinessDataLocalizedLabelBase
    {
        [Required]
        public string Label { get; set; }

        public int ObjectColumnNumber { get; set; }

        [Key]
        public Guid BusinessDataLocalizedLabelId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int LanguageId { get; set; }

        public Guid? ObjectId { get; set; }

        [Required]
        [StringLength(128)]
        public string ObjectColumnName { get; set; }

        public int ObjectIdTypeCode { get; set; }
    }
}
