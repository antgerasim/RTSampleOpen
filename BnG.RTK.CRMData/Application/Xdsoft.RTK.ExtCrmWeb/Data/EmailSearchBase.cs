namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailSearchBase")]
    public partial class EmailSearchBase
    {
        [Required]
        [StringLength(160)]
        public string EmailAddress { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid ParentObjectId { get; set; }

        [Key]
        public Guid EmailSearchId { get; set; }

        public int? ParentObjectTypeCode { get; set; }

        public int? EmailColumnNumber { get; set; }
    }
}
