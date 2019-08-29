namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardTypeBase")]
    public partial class CardTypeBase
    {
        public bool? IsBaseCard { get; set; }

        public bool? IsLiveOnly { get; set; }

        public int? IntCardOption { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [StringLength(100)]
        public string CardName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public DateTime? LastSyncTime { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int ClientAvailability { get; set; }

        public bool? BoolCardOption { get; set; }

        public string Actions { get; set; }

        public DateTime? ScheduleTime { get; set; }

        public bool? HasSnoozeDismiss { get; set; }

        [StringLength(250)]
        public string CardTypeIcon { get; set; }

        public bool? IsEnabled { get; set; }

        public int CardType { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public string StringCardOption { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool? IsPreviewCard { get; set; }

        [StringLength(250)]
        public string SummaryText { get; set; }

        [StringLength(128)]
        public string GroupType { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(100)]
        public string SoftTitle { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Key]
        public Guid CardTypeId { get; set; }
    }
}
