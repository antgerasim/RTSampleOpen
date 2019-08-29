namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecommendationModelVersionBase")]
    public partial class RecommendationModelVersionBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RecommendationModelVersionBase()
        {
            RecommendationModelVersionHistoryBase = new HashSet<RecommendationModelVersionHistoryBase>();
        }

        public Guid? CreatedBy { get; set; }

        public int? StatusCode { get; set; }

        public int? AzureModelBuildStatus { get; set; }

        public Guid OrganizationId { get; set; }

        public int? PercentileRank { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string AzureBuildId { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(100)]
        public string LogicAppRunId { get; set; }

        public int? BasketDataSynchronizationStatus { get; set; }

        public Guid RecommendationModelId { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public DateTime? BuildStartedOn { get; set; }

        [Key]
        public Guid RecommendationModelVersionId { get; set; }

        public int? CatalogSynchronizationStatus { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? BuildEndedOn { get; set; }

        [StringLength(125)]
        public string Name { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? CatalogCoverage { get; set; }

        public DateTime? CreatedOn { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Duration { get; set; }

        public virtual RecommendationModelBaseIds RecommendationModelBaseIds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecommendationModelVersionHistoryBase> RecommendationModelVersionHistoryBase { get; set; }
    }
}
