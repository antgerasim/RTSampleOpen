namespace Xdsoft.RTK.ExtCrmWeb.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskBase")]
    public partial class TaskBase
    {
        [Key]
        public Guid ActivityId { get; set; }

        public string new_executor_comment { get; set; }

        public string new_pm_comment { get; set; }

        public int? new_state { get; set; }

        public Guid? new_task_manager { get; set; }

        public Guid? new_link_t_activity_t_task { get; set; }

        public int? new_KeyTaskFor { get; set; }

        public int? new_Negotiation_Result { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? new_Delay_Duration { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? new_assignment_expire_sign { get; set; }

        public int? new_user_logical_decision { get; set; }

        public virtual ActivityPointerBase ActivityPointerBase { get; set; }

        public virtual new_t_activityBase new_t_activityBase { get; set; }

        public virtual SystemUserBase SystemUserBase { get; set; }
    }
}
