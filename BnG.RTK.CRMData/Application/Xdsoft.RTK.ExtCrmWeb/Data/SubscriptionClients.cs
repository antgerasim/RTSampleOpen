namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubscriptionClients
    {
        public Guid ClientId { get; set; }

        [StringLength(200)]
        public string MachineName { get; set; }

        public Guid SubscriptionId { get; set; }

        public bool? IsPrimaryClient { get; set; }

        [Key]
        public Guid SubscriptionClientId { get; set; }

        public virtual Subscription Subscription { get; set; }
    }
}
