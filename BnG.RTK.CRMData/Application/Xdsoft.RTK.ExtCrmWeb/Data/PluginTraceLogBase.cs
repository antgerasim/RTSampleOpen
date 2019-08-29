namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PluginTraceLogBase")]
    public partial class PluginTraceLogBase
    {
        public int? PerformanceConstructorDuration { get; set; }

        [Key]
        public Guid PluginTraceLogId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool IsSystemCreated { get; set; }

        public DateTime? PerformanceConstructorStartTime { get; set; }

        public int? PerformanceExecutionDuration { get; set; }

        public string Configuration { get; set; }

        public DateTime? PerformanceExecutionStartTime { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? OrganizationId { get; set; }

        public Guid? PersistenceKey { get; set; }

        public string ExceptionDetails { get; set; }

        public string MessageBlock { get; set; }

        public string Profile { get; set; }

        [StringLength(500)]
        public string PrimaryEntity { get; set; }

        public Guid? RequestId { get; set; }

        public Guid? CorrelationId { get; set; }

        public int? OperationType { get; set; }

        [StringLength(1024)]
        public string MessageName { get; set; }

        public Guid? CreatedBy { get; set; }

        public int? Depth { get; set; }

        public string SecureConfiguration { get; set; }

        public int? Mode { get; set; }

        public Guid? PluginStepId { get; set; }

        [StringLength(1024)]
        public string TypeName { get; set; }
    }
}
