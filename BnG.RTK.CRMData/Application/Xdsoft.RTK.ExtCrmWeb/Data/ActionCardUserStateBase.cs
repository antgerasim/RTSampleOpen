namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActionCardUserStateBase")]
    public partial class ActionCardUserStateBase
    {
        public Guid? TransactionCurrencyId { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid OwnerId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ActionCardUserStateId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int State { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime StartDate { get; set; }

        public Guid? ActionCardId { get; set; }

        public int? ActionCardIdObjectTypeCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OwnerIdType { get; set; }

        public virtual ActionCardBase ActionCardBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
