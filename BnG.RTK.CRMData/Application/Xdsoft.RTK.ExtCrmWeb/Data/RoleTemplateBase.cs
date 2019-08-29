namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleTemplateBase")]
    public partial class RoleTemplateBase
    {
        [Key]
        public Guid RoleTemplateId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool Upgrading { get; set; }
    }
}
