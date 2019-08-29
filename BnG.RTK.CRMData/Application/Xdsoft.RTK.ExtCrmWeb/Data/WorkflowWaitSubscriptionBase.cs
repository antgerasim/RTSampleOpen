namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkflowWaitSubscriptionBase")]
    public partial class WorkflowWaitSubscriptionBase
    {
        public Guid EntityId { get; set; }

        [Key]
        public Guid WorkflowWaitSubscriptionId { get; set; }

        public Guid AsyncOperationId { get; set; }

        public string Data { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Required]
        [StringLength(64)]
        public string EntityName { get; set; }

        public bool IsModified { get; set; }

        public bool? IsDeleted { get; set; }

        public string WaitOnAttributeList { get; set; }
    }
}
