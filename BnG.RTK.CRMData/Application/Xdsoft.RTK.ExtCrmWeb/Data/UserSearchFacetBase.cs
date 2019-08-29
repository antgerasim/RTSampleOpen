namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserSearchFacetBase")]
    public partial class UserSearchFacetBase
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string AttributeName { get; set; }

        public Guid UserSearchFacetId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string EntityName { get; set; }

        public int FacetOrder { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SystemUserId { get; set; }
    }
}
