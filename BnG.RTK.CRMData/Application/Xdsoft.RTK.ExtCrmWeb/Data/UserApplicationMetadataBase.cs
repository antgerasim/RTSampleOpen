namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserApplicationMetadataBase")]
    public partial class UserApplicationMetadataBase
    {
        public int? State { get; set; }

        public Guid OwnerId { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(64)]
        public string AssociatedEntityLogicalName { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        [Key]
        public Guid UserApplicationMetadataId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int? MetadataType { get; set; }

        public string Data { get; set; }

        public int? FormFactor { get; set; }

        public int? Lcid { get; set; }

        public int? MetadataSubtype { get; set; }

        [StringLength(36)]
        public string SourceId { get; set; }

        public bool? IsDefault { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int OwnerIdType { get; set; }

        public string Dependency { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
