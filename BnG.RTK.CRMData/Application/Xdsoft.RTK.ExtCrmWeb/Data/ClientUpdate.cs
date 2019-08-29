namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientUpdate")]
    public partial class ClientUpdate
    {
        public Guid ClientUpdateId { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string SqlScript { get; set; }

        public DateTime CreatedOn { get; set; }

        public int WhenExecute { get; set; }

        public bool WasExecuted { get; set; }
    }
}
