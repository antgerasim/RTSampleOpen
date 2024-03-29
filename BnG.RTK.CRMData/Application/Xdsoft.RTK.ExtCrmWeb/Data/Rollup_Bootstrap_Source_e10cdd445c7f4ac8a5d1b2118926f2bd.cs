namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rollup_Bootstrap_Source_e10cdd445c7f4ac8a5d1b2118926f2bd
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
