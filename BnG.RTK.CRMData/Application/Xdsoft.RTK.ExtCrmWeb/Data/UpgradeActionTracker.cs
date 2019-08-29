namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UpgradeActionTracker")]
    public partial class UpgradeActionTracker
    {
        [Key]
        [Column(Order = 0)]
        public Guid ActionId { get; set; }

        [StringLength(20)]
        public string UpgradeToVersionNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ExecutionOrder { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool WasExecuted { get; set; }

        public string ActionName { get; set; }

        public string Description { get; set; }

        [StringLength(64)]
        public string ExecutionTime { get; set; }

        public string HashFile { get; set; }

        public string HashValue { get; set; }

        public DateTime? CreatedOnUtc { get; set; }
    }
}
