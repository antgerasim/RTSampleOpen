namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DateTimeConversionTracker")]
    public partial class DateTimeConversionTracker
    {
        [Key]
        [Column(Order = 0)]
        public Guid EntityId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AttributeId { get; set; }

        public int? Status { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
