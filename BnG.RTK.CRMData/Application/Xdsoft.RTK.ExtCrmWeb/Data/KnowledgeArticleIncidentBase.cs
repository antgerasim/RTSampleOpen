namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KnowledgeArticleIncidentBase")]
    public partial class KnowledgeArticleIncidentBase
    {
        [Key]
        public Guid KnowledgeArticleIncidentId { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public decimal? ExchangeRate { get; set; }

        public int statecode { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? IncidentId { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? statuscode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        public bool? IsSentToCustomer { get; set; }

        public Guid? KnowledgeArticleId { get; set; }

        public int? KnowledgeUsage { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public virtual IncidentBase IncidentBase { get; set; }

        public virtual KnowledgeArticleBase KnowledgeArticleBase { get; set; }

        public virtual TransactionCurrencyBase TransactionCurrencyBase { get; set; }
    }
}
