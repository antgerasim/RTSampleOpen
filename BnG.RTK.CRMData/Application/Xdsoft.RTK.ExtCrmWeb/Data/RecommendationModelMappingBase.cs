namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecommendationModelMappingBase")]
    public partial class RecommendationModelMappingBase
    {
        [StringLength(100)]
        public string ProductLineItemRelationship { get; set; }

        [StringLength(100)]
        public string ProductField { get; set; }

        public string DataFilter { get; set; }

        public bool IsManaged { get; set; }

        public int? SynchronizedCount { get; set; }

        public DateTime OverwriteTime { get; set; }

        [StringLength(100)]
        public string Entity { get; set; }

        public Guid RecommendationModelMappingIdUnique { get; set; }

        public Guid? SupportedMapId { get; set; }

        public Guid? RecommendationModelVersionId { get; set; }

        public int? MappingType { get; set; }

        public int? ErrorCount { get; set; }

        [StringLength(100)]
        public string TransactionField { get; set; }

        public string FilterXml { get; set; }

        public Guid SolutionId { get; set; }

        public int ComponentState { get; set; }

        public Guid? RecommendationModelId { get; set; }

        public Guid OrganizationId { get; set; }

        [StringLength(100)]
        public string AccountField { get; set; }

        public string TimeRangeFilter { get; set; }

        [Key]
        public Guid RecommendationModelMappingId { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public int? AccountFieldPickList { get; set; }

        public int? ProductLineItemRelationshipPickList { get; set; }

        [StringLength(50)]
        public string AccountFieldDisplayName { get; set; }

        [StringLength(120)]
        public string ProductLineItemRelationshipDisplayName { get; set; }

        [StringLength(50)]
        public string EntityDisplayName { get; set; }

        [StringLength(50)]
        public string ProductFieldDisplayName { get; set; }

        public int? ProductFieldPickList { get; set; }

        public int? EntityPickList { get; set; }
    }
}
