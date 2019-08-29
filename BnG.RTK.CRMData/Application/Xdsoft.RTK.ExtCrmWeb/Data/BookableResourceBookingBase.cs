namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookableResourceBookingBase")]
    public partial class BookableResourceBookingBase
    {
        public Guid? BookingStatus { get; set; }

        [StringLength(1250)]
        public string TraversedPath { get; set; }

        public int? BookingType { get; set; }

        public DateTime? StartTime { get; set; }

        public int? ImportSequenceNumber { get; set; }

        [Key]
        public Guid BookableResourceBookingId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid OwnerId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public Guid? ProcessId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? StatusCode { get; set; }

        public int StateCode { get; set; }

        public int? Duration { get; set; }

        public Guid? StageId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? EndTime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? Resource { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? Header { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int OwnerIdType { get; set; }

        public virtual BookableResourceBase BookableResourceBase { get; set; }

        public virtual BookableResourceBookingHeaderBase BookableResourceBookingHeaderBase { get; set; }

        public virtual BookingStatusBase BookingStatusBase { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
