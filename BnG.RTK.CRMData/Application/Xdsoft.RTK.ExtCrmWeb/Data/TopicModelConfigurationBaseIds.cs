namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TopicModelConfigurationBaseIds
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TopicModelConfigurationBaseIds()
        {
            TopicModelBase = new HashSet<TopicModelBase>();
            TopicModelExecutionHistoryBase = new HashSet<TopicModelExecutionHistoryBase>();
        }

        [Key]
        public Guid TopicModelConfigurationId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TopicModelBase> TopicModelBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TopicModelExecutionHistoryBase> TopicModelExecutionHistoryBase { get; set; }
    }
}
