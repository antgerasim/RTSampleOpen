namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SharedCacheState")]
    public partial class SharedCacheState
    {
        [Key]
        public Guid OrganizationId { get; set; }

        public bool? IsCacheSharingEnabled { get; set; }
    }
}
