namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rollup_Bootstrap_Target_d2c321243c79e81180d3dbe78f6b8753
    {
        public int Id { get; set; }

        public Guid EntityId { get; set; }

        public Guid? ParentEntityId { get; set; }

        public decimal? OutputValue { get; set; }
    }
}
