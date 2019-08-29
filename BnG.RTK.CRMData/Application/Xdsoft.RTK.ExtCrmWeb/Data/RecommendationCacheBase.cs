namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecommendationCacheBase")]
    public partial class RecommendationCacheBase
    {
        public Guid? ItemId { get; set; }

        public Guid? RecommendedItemId { get; set; }

        public decimal RecommendationRating { get; set; }

        public int? RecommendationType { get; set; }

        [Key]
        public Guid RecommendationCacheId { get; set; }

        public Guid? RecommendationModelId { get; set; }

        public int RecommendationSource { get; set; }

        public Guid? AdditionalDataRecordId { get; set; }

        public bool? IsRecommendationActive { get; set; }

        public virtual ProductBase ProductBase { get; set; }

        public virtual ProductBase ProductBase1 { get; set; }

        public virtual ProductPriceLevelBase ProductPriceLevelBase { get; set; }

        public virtual RecommendationModelBaseIds RecommendationModelBaseIds { get; set; }
    }
}
