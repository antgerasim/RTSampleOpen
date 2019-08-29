namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraceRegardingBase")]
    public partial class TraceRegardingBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TraceRegardingBase()
        {
            TraceLogBase = new HashSet<TraceLogBase>();
        }

        public Guid? RegardingObjectOwningBusinessUnit { get; set; }

        public Guid? RegardingObjectId { get; set; }

        [Key]
        public Guid TraceRegardingId { get; set; }

        public Guid RegardingObjectOwnerId { get; set; }

        public int RegardingObjectTypeCodeForSharing { get; set; }

        public int? RegardingObjectOwnerIdType { get; set; }

        public int RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraceLogBase> TraceLogBase { get; set; }
    }
}
