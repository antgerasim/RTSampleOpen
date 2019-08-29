namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TextAnalyticsEntityMappingBase")]
    public partial class TextAnalyticsEntityMappingBase
    {
        public int ComponentState { get; set; }

        public int? ModelType { get; set; }

        public Guid? TopicModelConfigurationId { get; set; }

        [StringLength(50)]
        public string Entity { get; set; }

        [StringLength(100)]
        public string RelationshipName { get; set; }

        [Key]
        public Guid TextAnalyticsEntityMappingId { get; set; }

        public Guid TextAnalyticsEntityMappingIdUnique { get; set; }

        public Guid SolutionId { get; set; }

        public int? EntityPickList { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? KnowledgeSearchModelId { get; set; }

        [StringLength(50)]
        public string Field { get; set; }

        public DateTime OverwriteTime { get; set; }

        public int? FieldPickList { get; set; }

        public Guid? SimilarityRuleId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public bool IsManaged { get; set; }

        [StringLength(50)]
        public string EntityDisplayName { get; set; }

        [StringLength(50)]
        public string FieldDisplayName { get; set; }

        public bool? IsTextMatchMapping { get; set; }

        public Guid? AdvancedSimilarityRuleId { get; set; }
    }
}
