namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolutionAwareEntitiesForUpgrade")]
    public partial class SolutionAwareEntitiesForUpgrade
    {
        [Key]
        public Guid EntityId { get; set; }
    }
}
