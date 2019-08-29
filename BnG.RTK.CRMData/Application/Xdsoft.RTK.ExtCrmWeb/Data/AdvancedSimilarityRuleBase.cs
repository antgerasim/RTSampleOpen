namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdvancedSimilarityRuleBase")]
    public partial class AdvancedSimilarityRuleBase
    {
        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public string FetchXmlList { get; set; }

        public int? SourceEntity { get; set; }

        public int? FilterResultByStatus { get; set; }

        public bool IsManaged { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public string Description { get; set; }

        public bool? IsAzureMLRequired { get; set; }

        public DateTime OverwriteTime { get; set; }

        public int? NgramSize { get; set; }

        public int? MaxNumberKeyphrases { get; set; }

        public Guid SolutionId { get; set; }

        [Key]
        public Guid AdvancedSimilarityRuleId { get; set; }

        public int StateCode { get; set; }

        public string ExactMatchList { get; set; }

        [StringLength(50)]
        public string FilterResultByStatusDisplayName { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public int ComponentState { get; set; }

        public int? StatusCode { get; set; }

        public Guid AdvancedSimilarityRuleIdUnique { get; set; }

        [StringLength(100)]
        public string Entity { get; set; }

        public Guid? AzureServiceConnectionId { get; set; }
    }
}
