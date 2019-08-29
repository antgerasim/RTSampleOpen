namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KnowledgeSearchModelBase")]
    public partial class KnowledgeSearchModelBase
    {
        public int? SourceEntity { get; set; }

        public int? NgramSize { get; set; }

        public Guid OrganizationId { get; set; }

        public Guid KnowledgeSearchModelIdUnique { get; set; }

        [Key]
        public Guid KnowledgeSearchModelId { get; set; }

        public Guid SolutionId { get; set; }

        public DateTime OverwriteTime { get; set; }

        public Guid? AzureServiceConnectionId { get; set; }

        public int? StatusCode { get; set; }

        public string FetchXmlList { get; set; }

        public Guid? SupportingSolutionId { get; set; }

        [StringLength(100)]
        public string Entity { get; set; }

        public bool IsManaged { get; set; }

        public int? MaxKeyWords { get; set; }

        public string Description { get; set; }

        public int ComponentState { get; set; }

        public int StateCode { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
