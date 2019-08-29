namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemUserProfiles
    {
        public Guid SystemUserId { get; set; }

        public Guid FieldSecurityProfileId { get; set; }

        [Key]
        public Guid SystemUserProfileId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }
    }
}
