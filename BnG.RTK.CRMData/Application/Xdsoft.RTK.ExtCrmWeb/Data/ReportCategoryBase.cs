namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportCategoryBase")]
    public partial class ReportCategoryBase
    {
        public Guid? ModifiedBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? CategoryCode { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid ReportCategoryId { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid ReportId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SolutionId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid ReportCategoryIdUnique { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public bool IsManaged { get; set; }

        public decimal? ExchangeRate { get; set; }

        public bool IsCustomizable { get; set; }

        public Guid? TransactionCurrencyId { get; set; }
    }
}
