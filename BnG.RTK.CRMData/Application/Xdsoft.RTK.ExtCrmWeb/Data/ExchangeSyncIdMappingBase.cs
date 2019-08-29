namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExchangeSyncIdMappingBase")]
    public partial class ExchangeSyncIdMappingBase
    {
        [Key]
        public Guid ExchangeSyncIdmappingId { get; set; }

        public Guid? ObjectId { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid OwnerId { get; set; }

        public int? FromCrmChangeType { get; set; }

        public bool? IsDeletedInExchange { get; set; }

        public int? ObjectTypeCode { get; set; }

        public int? LastSyncErrorCode { get; set; }

        public int? UserDecision { get; set; }

        public bool? IsUnlinkedInCRM { get; set; }

        public int? Retries { get; set; }

        public int? ToCrmChangeType { get; set; }

        [StringLength(1024)]
        public string ExchangeEntryId { get; set; }

        [StringLength(1024)]
        public string LastSyncError { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int OwnerIdType { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? LastSyncErrorOccurredOn { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
