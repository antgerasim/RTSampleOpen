namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeadProduct")]
    public partial class LeadProduct
    {
        public Guid ProductId { get; set; }

        public Guid LeadId { get; set; }

        public Guid LeadProductId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual LeadBase LeadBase { get; set; }

        public virtual ProductBase ProductBase { get; set; }
    }
}
