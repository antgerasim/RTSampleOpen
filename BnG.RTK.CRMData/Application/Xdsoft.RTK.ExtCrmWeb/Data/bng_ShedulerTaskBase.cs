namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bng_ShedulerTaskBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bng_ShedulerTaskBase()
        {
            bng_SchedulerSessionBase = new HashSet<bng_SchedulerSessionBase>();
        }

        [Key]
        public Guid bng_ShedulerTaskId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid OwnerId { get; set; }

        public int OwnerIdType { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int statecode { get; set; }

        public int? statuscode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(100)]
        public string bng_name { get; set; }

        [StringLength(100)]
        public string bng_Cron { get; set; }

        [StringLength(400)]
        public string bng_CronDescription { get; set; }

        public string bng_Description { get; set; }

        public bool? bng_IsRunning { get; set; }

        public DateTime? bng_LastTaskRun { get; set; }

        public string bng_Query { get; set; }

        public int? bng_QueryType { get; set; }

        public int? bng_StartType { get; set; }

        public Guid? bng_WorkflowId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(4000)]
        public string bng_CRONFormat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bng_SchedulerSessionBase> bng_SchedulerSessionBase { get; set; }

        public virtual WorkflowBaseIds WorkflowBaseIds { get; set; }

        public virtual BusinessUnitBase BusinessUnitBase { get; set; }

        public virtual OwnerBase OwnerBase { get; set; }
    }
}
