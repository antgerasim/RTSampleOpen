namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class new_new_package_of_documents_new_expertiseBase
    {
        [Key]
        public Guid new_new_package_of_documents_new_expertiseId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid new_package_of_documentsid { get; set; }

        public Guid new_expertiseid { get; set; }

        public virtual new_expertiseBase new_expertiseBase { get; set; }

        public virtual new_Package_of_documentsBase new_Package_of_documentsBase { get; set; }
    }
}
