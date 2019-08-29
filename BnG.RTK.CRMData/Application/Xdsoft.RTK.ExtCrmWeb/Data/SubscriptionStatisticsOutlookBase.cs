namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubscriptionStatisticsOutlookBase")]
    public partial class SubscriptionStatisticsOutlookBase
    {
        public bool FullSyncRequired { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectTypeCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SubscriptionId { get; set; }
    }
}
