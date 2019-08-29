namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeStampDateMapping")]
    public partial class TimeStampDateMapping
    {
        public long TimeStamp { get; set; }

        public DateTime Date { get; set; }

        public Guid TimeStampDateMappingId { get; set; }
    }
}
