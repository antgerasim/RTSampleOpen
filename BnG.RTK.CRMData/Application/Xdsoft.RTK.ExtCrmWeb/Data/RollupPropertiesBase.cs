namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RollupPropertiesBase")]
    public partial class RollupPropertiesBase
    {
        public int? BootstrapStepNumber { get; set; }

        public int InitialValueCalculationStatus { get; set; }

        [StringLength(64)]
        public string RollupEntityPrimaryKeyPhysicalName { get; set; }

        public int AggregateType { get; set; }

        [StringLength(4000)]
        public string AggregateFilterAttributes { get; set; }

        [StringLength(64)]
        public string RollupStateAttributePhysicalName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        [Key]
        public Guid RollupPropertiesId { get; set; }

        public bool? AllowHierarchyOnSource { get; set; }

        public int AggregateEntityTypeCode { get; set; }

        [Required]
        [StringLength(50)]
        public string RollupAttributeLogicalName { get; set; }

        [Required]
        [StringLength(64)]
        public string AggregateEntityLogicalName { get; set; }

        public int? BootstrapTargetPointer { get; set; }

        public Guid? IncrementalRollupAsyncJobId { get; set; }

        public Guid? BootstrapRollupAsyncJobId { get; set; }

        [StringLength(4000)]
        public string RollupFilterAttributes { get; set; }

        public int? StatusCode { get; set; }

        public int StateCode { get; set; }

        [Required]
        [StringLength(64)]
        public string DataType { get; set; }

        public DateTime? LastCalculationTime { get; set; }

        [StringLength(4000)]
        public string AggregateRelationshipName { get; set; }

        [StringLength(4000)]
        public string SourceHierarchicalRelationshipName { get; set; }

        public int? BootstrapRetryCount { get; set; }

        [StringLength(64)]
        public string RollupEntityBaseTableName { get; set; }

        [Required]
        [StringLength(64)]
        public string RollupEntityLogicalName { get; set; }

        public int? BootstrapCurrentDepth { get; set; }

        public int RollupEntityTypeCode { get; set; }

        [StringLength(50)]
        public string AggregateAttributeLogicalName { get; set; }

        public int? IsActivityPartyIncluded { get; set; }
    }
}
