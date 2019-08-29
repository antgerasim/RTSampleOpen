namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SyncErrorBase")]
    public partial class SyncErrorBase
    {
        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid OwnerId { get; set; }

        [Key]
        public Guid SyncErrorId { get; set; }

        public string ActionData { get; set; }

        public DateTime CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedBy { get; set; }

        public string ErrorDetail { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Action { get; set; }

        public Guid? RegardingObjectId { get; set; }

        [StringLength(1000)]
        public string ErrorMessage { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public int OwnerIdType { get; set; }

        public int? RegardingObjectTypeCode { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdName { get; set; }

        [StringLength(4000)]
        public string RegardingObjectIdYomiName { get; set; }

        public DateTime? ErrorTime { get; set; }

        public string RequestData { get; set; }

        public string ErrorCode { get; set; }

        public string Description { get; set; }

        public int? ErrorType { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int StateCode { get; set; }

        public int? StatusCode { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
