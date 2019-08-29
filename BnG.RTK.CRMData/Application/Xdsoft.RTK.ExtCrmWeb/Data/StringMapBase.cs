namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StringMapBase")]
    public partial class StringMapBase
    {
        public int ObjectTypeCode { get; set; }

        [Required]
        [StringLength(100)]
        public string AttributeName { get; set; }

        public int AttributeValue { get; set; }

        public int LangId { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(4000)]
        public string Value { get; set; }

        public int? DisplayOrder { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid StringMapId { get; set; }
    }
}
