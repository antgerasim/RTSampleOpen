namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MatchCode6aefcc923b8b4c5ebe286f077c2227a3
    {
        [Key]
        public Guid ObjectId { get; set; }

        [StringLength(450)]
        public string MatchCode { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
