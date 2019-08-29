namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSalesLiterature")]
    public partial class ProductSalesLiterature
    {
        public Guid ProductId { get; set; }

        public Guid SalesLiteratureId { get; set; }

        public Guid ProductSalesLiteratureId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual ProductBase ProductBase { get; set; }

        public virtual SalesLiteratureBase SalesLiteratureBase { get; set; }
    }
}
