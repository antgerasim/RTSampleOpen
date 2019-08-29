namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CascadeDeleteEntitiesTopologicalOrder")]
    public partial class CascadeDeleteEntitiesTopologicalOrder
    {
        [Key]
        public int OrderNumber { get; set; }

        public int ObjectTypeCode { get; set; }
    }
}
