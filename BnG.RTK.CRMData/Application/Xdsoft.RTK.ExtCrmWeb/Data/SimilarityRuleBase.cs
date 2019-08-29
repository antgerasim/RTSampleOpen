namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SimilarityRuleBase")]
    public partial class SimilarityRuleBase
    {
        public string Description { get; set; }

        public int MatchingEntityTypeCode { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public Guid SimilarityRuleIdUnique { get; set; }

        public int statecode { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsManaged { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? OrganizationId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public string FetchXmlList { get; set; }

        public int? MaxKeyWords { get; set; }

        public bool? ExcludeInactiveRecords { get; set; }

        [StringLength(160)]
        public string BaseEntityName { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentState { get; set; }

        public Guid? TransactionCurrencyId { get; set; }

        [StringLength(48)]
        public string IntroducedVersion { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public string RuleConditionXml { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SimilarityRuleId { get; set; }

        public int? statuscode { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OverwriteTime { get; set; }

        [StringLength(160)]
        public string MatchingEntityName { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid SolutionId { get; set; }

        public string ActiveRuleFetchXML { get; set; }

        public int BaseEntityTypeCode { get; set; }

        public int? NgramSize { get; set; }

        public decimal? ExchangeRate { get; set; }
    }
}
