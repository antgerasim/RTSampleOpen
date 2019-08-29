namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityPartyBase")]
    public partial class ActivityPartyBase
    {
        public Guid ActivityId { get; set; }

        [Key]
        public Guid ActivityPartyId { get; set; }

        public Guid? PartyId { get; set; }

        public int PartyObjectTypeCode { get; set; }

        public int ParticipationTypeMask { get; set; }

        [StringLength(200)]
        public string AddressUsed { get; set; }

        [StringLength(4000)]
        public string PartyIdName { get; set; }

        public double? Effort { get; set; }

        [StringLength(1024)]
        public string ExchangeEntryId { get; set; }

        public Guid? ResourceSpecId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public bool? DoNotPhone { get; set; }

        public DateTime? ScheduledEnd { get; set; }

        public DateTime? ScheduledStart { get; set; }

        public bool IsPartyDeleted { get; set; }

        public int? AddressUsedEmailColumnNumber { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase { get; set; }
    }
}
