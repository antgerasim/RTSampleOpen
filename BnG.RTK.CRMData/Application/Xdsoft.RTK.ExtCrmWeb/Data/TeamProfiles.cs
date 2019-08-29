namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TeamProfiles
    {
        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid TeamProfileId { get; set; }

        public Guid FieldSecurityProfileId { get; set; }

        public Guid TeamId { get; set; }

        public virtual TeamBase TeamBase { get; set; }
    }
}
