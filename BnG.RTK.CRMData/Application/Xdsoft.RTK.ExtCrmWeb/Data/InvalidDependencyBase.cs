namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvalidDependencyBase")]
    public partial class InvalidDependencyBase
    {
        public bool? IsExistingNodeRequiredComponent { get; set; }

        public int ExistingDependencyType { get; set; }

        public int MissingComponentLookupType { get; set; }

        public Guid? MissingComponentId { get; set; }

        public string MissingComponentInfo { get; set; }

        [Key]
        public Guid InvalidDependencyId { get; set; }

        public Guid? ExistingComponentId { get; set; }

        public int? ExistingComponentType { get; set; }

        public int MissingComponentType { get; set; }
    }
}
