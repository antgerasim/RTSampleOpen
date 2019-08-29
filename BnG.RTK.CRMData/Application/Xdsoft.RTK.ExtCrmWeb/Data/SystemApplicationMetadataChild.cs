namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemApplicationMetadataChild")]
    public partial class SystemApplicationMetadataChild
    {
        public Guid Id { get; set; }

        public int? MetadataType { get; set; }

        public int? FormFactor { get; set; }

        [StringLength(300)]
        public string SourceId { get; set; }

        public int? Lcid { get; set; }

        [StringLength(64)]
        public string AssociatedEntityLogicalName { get; set; }

        public int? ChildMetadataType { get; set; }

        [StringLength(300)]
        public string ChildSourceId { get; set; }

        [StringLength(64)]
        public string ChildAssociatedEntityLogicalName { get; set; }

        public Guid? SystemApplicationMetadataId { get; set; }

        public Guid? SystemApplicationMetadataChildId { get; set; }
    }
}
