namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rollup_Bootstrap_Orphans_f9e939a60f38e81180d2d91123acd40c
    {
        public int Id { get; set; }

        public Guid EntityId { get; set; }

        public Guid? ParentEntityId { get; set; }

        public int? Status { get; set; }

        public decimal? ExchangeRate { get; set; }

        public decimal? OutputValue { get; set; }

        public int? CountValue { get; set; }
    }
}
