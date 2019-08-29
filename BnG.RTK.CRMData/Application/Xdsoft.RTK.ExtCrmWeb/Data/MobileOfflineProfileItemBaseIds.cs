namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MobileOfflineProfileItemBaseIds
    {
        [Key]
        public Guid MobileOfflineProfileItemId { get; set; }
    }
}
