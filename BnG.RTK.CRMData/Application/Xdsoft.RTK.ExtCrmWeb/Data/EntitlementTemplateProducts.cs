namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EntitlementTemplateProducts
    {
        [Key]
        public Guid EntitlementTemplateProductId { get; set; }

        public Guid ProductId { get; set; }

        public Guid EntitlementTemplateId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual EntitlementTemplateBase EntitlementTemplateBase { get; set; }

        public virtual ProductBase ProductBase { get; set; }
    }
}
