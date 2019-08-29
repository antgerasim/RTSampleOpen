namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompetitorProduct")]
    public partial class CompetitorProduct
    {
        public Guid CompetitorId { get; set; }

        public Guid ProductId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid CompetitorProductId { get; set; }

        public virtual CompetitorBase CompetitorBase { get; set; }

        public virtual ProductBase ProductBase { get; set; }
    }
}
