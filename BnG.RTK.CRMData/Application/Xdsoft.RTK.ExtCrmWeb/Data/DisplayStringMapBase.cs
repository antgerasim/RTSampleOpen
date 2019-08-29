namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DisplayStringMapBase")]
    public partial class DisplayStringMapBase
    {
        public int ObjectTypeCode { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid DisplayStringMapId { get; set; }

        public Guid DisplayStringId { get; set; }

        public bool IsManaged { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid DisplayStringMapIdUnique { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime OverwriteTime { get; set; }
    }
}
