namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResourceGroupExpansionBase")]
    public partial class ResourceGroupExpansionBase
    {
        public Guid ObjectId { get; set; }

        [Key]
        public Guid ResourceGroupExpansionId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid ItemId { get; set; }

        public int MethodCode { get; set; }
    }
}
