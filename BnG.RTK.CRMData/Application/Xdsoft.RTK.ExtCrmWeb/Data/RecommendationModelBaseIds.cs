namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RecommendationModelBaseIds
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RecommendationModelBaseIds()
        {
            RecommendationCacheBase = new HashSet<RecommendationCacheBase>();
            RecommendationModelVersionBase = new HashSet<RecommendationModelVersionBase>();
        }

        [Key]
        public Guid RecommendationModelId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecommendationCacheBase> RecommendationCacheBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecommendationModelVersionBase> RecommendationModelVersionBase { get; set; }
    }
}
