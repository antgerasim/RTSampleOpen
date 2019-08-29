namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EntitlementTemplateChannelBase")]
    public partial class EntitlementTemplateChannelBase
    {
        public decimal? ExchangeRate { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? EntitlementTemplateId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        public Guid EntitlementTemplateChannelId { get; set; }

        public int? Channel { get; set; }

        public Guid? CreatedBy { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public Guid OrganizationId { get; set; }

        public decimal? TotalTerms { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public virtual EntitlementTemplateBase EntitlementTemplateBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
