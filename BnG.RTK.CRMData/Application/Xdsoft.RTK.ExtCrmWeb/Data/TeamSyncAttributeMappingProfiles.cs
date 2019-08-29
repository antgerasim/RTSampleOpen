namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TeamSyncAttributeMappingProfiles
    {
        [Key]
        [Column(Order = 0)]
        public Guid TeamSyncAttributeMappingProfileId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TeamId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SyncAttributeMappingProfileId { get; set; }

        public virtual TeamBase TeamBase { get; set; }
    }
}
