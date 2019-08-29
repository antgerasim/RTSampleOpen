namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DependencyBase")]
    public partial class DependencyBase
    {
        [Key]
        public Guid DependencyId { get; set; }

        public Guid? DependentComponentNodeId { get; set; }

        public int DependencyType { get; set; }

        public Guid? RequiredComponentNodeId { get; set; }

        public virtual DependencyNodeBase DependencyNodeBase { get; set; }

        public virtual DependencyNodeBase DependencyNodeBase1 { get; set; }
    }
}
