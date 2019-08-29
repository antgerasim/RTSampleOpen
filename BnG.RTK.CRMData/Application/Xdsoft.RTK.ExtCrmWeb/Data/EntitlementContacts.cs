namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EntitlementContacts
    {
        public Guid ContactId { get; set; }

        public Guid EntitlementId { get; set; }

        [Key]
        public Guid EntitlementContactId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual ContactBase ContactBase { get; set; }

        public virtual EntitlementBase EntitlementBase { get; set; }
    }
}
