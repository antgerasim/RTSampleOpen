namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubscriptionStatisticsOfflineBase")]
    public partial class SubscriptionStatisticsOfflineBase
    {
        [Key]
        [Column(Order = 0)]
        public Guid SubscriptionId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectTypeCode { get; set; }

        public bool FullSyncRequired { get; set; }
    }
}
