namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rollup_Bootstrap_Target_306845ef446a42e58df811c31bafaded
    {
        public int Id { get; set; }

        public Guid EntityId { get; set; }

        public Guid? ParentEntityId { get; set; }

        public decimal? OutputValue { get; set; }
    }
}
