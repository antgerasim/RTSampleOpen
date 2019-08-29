namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecommendationModelBase")]
    public partial class RecommendationModelBase
    {
        public DateTime? CreatedOn { get; set; }

        public DateTime? ValidUntil { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? RecommendationModelVersionId { get; set; }

        public int? BasketDataLastSynchronizationStatus { get; set; }

        public decimal ProductCatalogCrosssellLinkRating { get; set; }

        public Guid OrganizationId { get; set; }

        public DateTime? CatalogLastSynchronizedOn { get; set; }

        [StringLength(100)]
        public string AzureModelId { get; set; }

        public bool IsManaged { get; set; }

        public int ComponentState { get; set; }

        public DateTime? BasketDataLastSynchronizedOn { get; set; }

        public decimal ProductCatalogAccessoryLinkRating { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Guid? AzureServiceConnectionId { get; set; }

        public DateTime OverwriteTime { get; set; }

        public Guid SolutionId { get; set; }

        public string Description { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public int RecommendationModelVersionCount { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        public Guid RecommendationModelIdUnique { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int StateCode { get; set; }

        public int? StatusCode { get; set; }

        [StringLength(100)]
        public string ProductCatalogName { get; set; }

        public int MaxRecommendations { get; set; }

        public decimal MinRecommendationRating { get; set; }

        [Key]
        public Guid RecommendationModelId { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int? CatalogLastSynchronizationStatus { get; set; }

        public int MaximumVersions { get; set; }
    }
}
