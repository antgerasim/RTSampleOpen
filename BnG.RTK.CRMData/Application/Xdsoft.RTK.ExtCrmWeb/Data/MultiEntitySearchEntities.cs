namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MultiEntitySearchEntities
    {
        public Guid MultiEntitySearchId { get; set; }

        public int? EntityOrder { get; set; }

        [Key]
        public Guid MultiEntitySearchEntityId { get; set; }

        [StringLength(64)]
        public string EntityName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual MultiEntitySearchBase MultiEntitySearchBase { get; set; }
    }
}
