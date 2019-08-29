namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganizationStatisticBase")]
    public partial class OrganizationStatisticBase
    {
        public int? Hour { get; set; }

        public int? StatisticType { get; set; }

        [Key]
        public Guid OrganizationStatisticId { get; set; }

        [StringLength(256)]
        public string ServerName { get; set; }

        public int? StatisticValue { get; set; }
    }
}
