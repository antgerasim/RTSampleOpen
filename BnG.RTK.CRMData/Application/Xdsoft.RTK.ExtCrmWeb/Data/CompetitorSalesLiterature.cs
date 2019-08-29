namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompetitorSalesLiterature")]
    public partial class CompetitorSalesLiterature
    {
        public Guid CompetitorId { get; set; }

        public Guid SalesLiteratureId { get; set; }

        public Guid CompetitorSalesLiteratureId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual CompetitorBase CompetitorBase { get; set; }

        public virtual SalesLiteratureBase SalesLiteratureBase { get; set; }
    }
}
