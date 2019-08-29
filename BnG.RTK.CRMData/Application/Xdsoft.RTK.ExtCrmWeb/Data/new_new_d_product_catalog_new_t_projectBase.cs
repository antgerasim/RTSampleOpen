namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_new_d_product_catalog_new_t_projectBase
    {
        [Key]
        public Guid new_new_d_product_catalog_new_t_projectId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid new_d_product_catalogid { get; set; }

        public Guid new_t_projectid { get; set; }

        public virtual new_d_product_catalogBase new_d_product_catalogBase { get; set; }

        public virtual new_t_projectBase new_t_projectBase { get; set; }
    }
}
