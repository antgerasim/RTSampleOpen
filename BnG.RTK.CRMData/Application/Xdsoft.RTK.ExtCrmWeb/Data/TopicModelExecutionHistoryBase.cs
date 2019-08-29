namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TopicModelExecutionHistoryBase")]
    public partial class TopicModelExecutionHistoryBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TopicModelExecutionHistoryBase()
        {
            TopicHistoryBase = new HashSet<TopicHistoryBase>();
        }

        public DateTime? StartTime { get; set; }

        public Guid? TopicModelId { get; set; }

        public int? NumberOfTopicsFound { get; set; }

        public bool? IsTestExecution { get; set; }

        public int? MaxTopics { get; set; }

        public Guid? TopicModelConfigurationId { get; set; }

        public int? Status { get; set; }

        public int? StatusReason { get; set; }

        public int? RecordsProcessed { get; set; }

        public Guid? OrganizationId { get; set; }

        [Key]
        public Guid TopicModelExecutionHistoryId { get; set; }

        public string FetchXmlList { get; set; }

        public int? TotalTime { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public string ErrorDetails { get; set; }

        [StringLength(100)]
        public string RecordCorrelationId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TopicHistoryBase> TopicHistoryBase { get; set; }

        public virtual TopicModelBase TopicModelBase { get; set; }

        public virtual TopicModelConfigurationBaseIds TopicModelConfigurationBaseIds { get; set; }
    }
}
