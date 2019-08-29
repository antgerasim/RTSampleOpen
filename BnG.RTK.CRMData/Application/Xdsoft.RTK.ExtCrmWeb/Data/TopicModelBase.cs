namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TopicModelBase")]
    public partial class TopicModelBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TopicModelBase()
        {
            TopicModelExecutionHistoryBase = new HashSet<TopicModelExecutionHistoryBase>();
        }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string BuildRecurrence { get; set; }

        public int? MaxTopics { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? AzureServiceConnectionId { get; set; }

        [StringLength(100)]
        public string AzureSchedulerJobName { get; set; }

        public DateTime? EndTime { get; set; }

        [Key]
        public Guid TopicModelId { get; set; }

        public int? AvgNumberofTopics { get; set; }

        public Guid? ConfigurationUsed { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid OrganizationId { get; set; }

        public int? MaxNumberofTopics { get; set; }

        public int? SourceEntity { get; set; }

        public DateTime? StartTime { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public int? StatusCode { get; set; }

        public string Description { get; set; }

        public int StateCode { get; set; }

        public Guid? ModifiedBy { get; set; }

        public int? TotalTopicsFound { get; set; }

        public DateTime? TopicsLastCreatedOn { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        [StringLength(100)]
        public string AzureSchedulerTestJobName { get; set; }

        [StringLength(100)]
        public string AzureSchedulerOnDemandJobName { get; set; }

        public virtual AzureServiceConnectionBase AzureServiceConnectionBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TopicModelExecutionHistoryBase> TopicModelExecutionHistoryBase { get; set; }

        public virtual TopicModelConfigurationBaseIds TopicModelConfigurationBaseIds { get; set; }
    }
}
