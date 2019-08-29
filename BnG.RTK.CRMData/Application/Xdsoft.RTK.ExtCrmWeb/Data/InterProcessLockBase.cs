namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InterProcessLockBase")]
    public partial class InterProcessLockBase
    {
        [Key]
        public Guid InterProcessLockId { get; set; }

        public Guid Token { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
