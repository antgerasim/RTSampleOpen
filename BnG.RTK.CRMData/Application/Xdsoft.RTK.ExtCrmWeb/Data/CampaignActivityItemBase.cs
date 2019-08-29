namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CampaignActivityItemBase")]
    public partial class CampaignActivityItemBase
    {
        public Guid ItemId { get; set; }

        public int ItemObjectTypeCode { get; set; }

        [Key]
        public Guid CampaignActivityItemId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid CampaignActivityId { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase { get; set; }
    }
}
