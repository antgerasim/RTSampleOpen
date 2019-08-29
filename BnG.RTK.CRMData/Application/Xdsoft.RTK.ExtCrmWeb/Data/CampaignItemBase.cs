namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CampaignItemBase")]
    public partial class CampaignItemBase
    {
        public int EntityType { get; set; }

        public Guid EntityId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid CampaignItemId { get; set; }

        public Guid CampaignId { get; set; }

        public virtual CampaignBase CampaignBase { get; set; }
    }
}
