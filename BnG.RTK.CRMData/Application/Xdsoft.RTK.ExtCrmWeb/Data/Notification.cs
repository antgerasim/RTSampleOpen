namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notification")]
    public partial class Notification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationNumber { get; set; }

        public string EventData { get; set; }

        public DateTime CreatedOn { get; set; }

        public int EventId { get; set; }

        public Guid NotificationId { get; set; }

        [Required]
        [StringLength(40)]
        public string CreatedOnString { get; set; }

        public Guid OrganizationId { get; set; }
    }
}
