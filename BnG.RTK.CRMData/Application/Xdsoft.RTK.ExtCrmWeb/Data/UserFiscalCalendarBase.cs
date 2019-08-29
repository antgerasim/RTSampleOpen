namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserFiscalCalendarBase")]
    public partial class UserFiscalCalendarBase
    {
        [Key]
        public Guid UserFiscalCalendarId { get; set; }

        public Guid? SalesPersonId { get; set; }

        public int? FiscalPeriodType { get; set; }

        public DateTime? EffectiveOn { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period11 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period12 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period13 { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period4_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period11_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period3_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period1_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period6_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period8_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period9_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period7_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period5_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period13_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period10_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period12_Base { get; set; }

        [Column(TypeName = "money")]
        public decimal? Period2_Base { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase1 { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase2 { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase3 { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase4 { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase5 { get; set; }
    }
}
