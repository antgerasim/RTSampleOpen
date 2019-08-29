namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rollup_Bootstrap_306845ef446a42e58df811c31bafaded
    {
        public int Id { get; set; }

        public Guid EntityId { get; set; }

        public Guid? ParentEntityId { get; set; }

        public int? Depth { get; set; }

        public decimal? ExchangeRate { get; set; }

        public decimal? OutputValue { get; set; }

        public int? CountValue { get; set; }

        public int? Status { get; set; }

        public DateTime? CalculatedDateTime { get; set; }
    }
}
