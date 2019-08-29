namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemUserSyncMappingProfiles
    {
        [Key]
        [Column(Order = 0)]
        public Guid SyncAttributeMappingProfileId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SystemUserId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SystemUserSyncMappingProfileId { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }
    }
}
