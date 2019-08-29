namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemApplicationMetadataBase")]
    public partial class SystemApplicationMetadataBase
    {
        [StringLength(100)]
        public string Version { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? MetadataType { get; set; }

        [StringLength(300)]
        public string SourceId { get; set; }

        public int? FormFactor { get; set; }

        public Guid? ModifiedBy { get; set; }

        public string Data { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? Lcid { get; set; }

        [StringLength(64)]
        public string AssociatedEntityLogicalName { get; set; }

        [Key]
        public Guid SystemApplicationMetadataId { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? State { get; set; }

        public bool? IsDefault { get; set; }

        public Guid OrganizationId { get; set; }

        public int? MetadataSubtype { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public string Dependency { get; set; }
    }
}
