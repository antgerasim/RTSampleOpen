namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookableResourceBookingExchangeSyncIdMappingBase")]
    public partial class BookableResourceBookingExchangeSyncIdMappingBase
    {
        public Guid OwnerId { get; set; }

        public int? LastSyncErrorCode { get; set; }

        public int? Retries { get; set; }

        public DateTime? LastSyncErrorOccurredOn { get; set; }

        [StringLength(1024)]
        public string ExchangeEntryId { get; set; }

        public Guid? BookableResourceBookingId { get; set; }

        public long? SyncVersionNumber { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int? SyncStatus { get; set; }

        [Key]
        public Guid BookableResourceBookingExchangeSyncIdMappingId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool? IsDeletedInExchange { get; set; }

        [StringLength(1024)]
        public string LastSyncError { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? UserId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
